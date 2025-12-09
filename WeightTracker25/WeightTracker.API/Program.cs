using Microsoft.EntityFrameworkCore;
using WeightTracker.Infrastructure.Context;
using WeightTracker.Infrastructure.Repositories;
using WeightTracker.Infrastructure.Services;
using WeightTracker.Domain.IRepositories;
using WeightTracker.Application.Services;
using WeightTracker.Application.IServices;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.Google;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<WeightTrackerDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configure JWT Authentication
var jwtKey = builder.Configuration["Jwt:Key"];
var jwtIssuer = builder.Configuration["Jwt:Issuer"];
var jwtAudience = builder.Configuration["Jwt:Audience"];

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtIssuer,
        ValidAudience = jwtAudience,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey ?? ""))
    };
})
.AddGoogle(googleOptions =>
{
    googleOptions.ClientId = builder.Configuration["Authentication:Google:ClientId"];
    googleOptions.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];
    googleOptions.CallbackPath = "/signin-google";
    googleOptions.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
});

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorClient", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Register repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRecordRepository, RecordRepository>();
builder.Services.AddScoped<IPasswordResetTokenRepository, PasswordResetTokenRepository>();

// Register services
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IRecordService, RecordService>();
builder.Services.AddScoped<IAuthentificationService, AuthentificationService>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IEmailService, EmailService>();

// Register database migration and backup services
builder.Services.AddScoped<DatabaseMigrationService>();
builder.Services.AddSingleton(sp => 
{
    var logger = sp.GetRequiredService<ILogger<DatabaseBackupService>>();
    var backupPath = Path.Combine(AppContext.BaseDirectory, "backups");
    return new DatabaseBackupService(logger, backupPath);
});

var app = builder.Build();

// Apply database migrations with backup and proper error handling
using (var scope = app.Services.CreateScope())
{
    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
    var context = scope.ServiceProvider.GetRequiredService<WeightTrackerDbContext>();
    var migrationService = scope.ServiceProvider.GetRequiredService<DatabaseMigrationService>();
    var backupService = scope.ServiceProvider.GetRequiredService<DatabaseBackupService>();
    
    try
    {
        logger.LogInformation("Starting database initialization...");
        
        // Get database path from connection string
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        var dbPath = connectionString?.Replace("Data Source=", "").Trim() ?? "weightTracker.db";
        
        // Make path absolute if relative
        if (!Path.IsPathRooted(dbPath))
        {
            dbPath = Path.Combine(AppContext.BaseDirectory, dbPath);
        }
        
        // Create backup before migration if database exists
        if (File.Exists(dbPath))
        {
            logger.LogInformation("Creating backup before applying migrations...");
            var backupResult = await backupService.CreateBackupAsync(dbPath);
            
            if (backupResult.Success)
            {
                logger.LogInformation($"Backup created successfully at: {backupResult.BackupPath}");
            }
            else
            {
                logger.LogWarning($"Backup failed: {backupResult.ErrorMessage}");
            }
        }
        
        // Get application version
        var assembly = System.Reflection.Assembly.GetExecutingAssembly();
        var appVersion = assembly.GetName().Version?.ToString() ?? "1.0.0.0";
        var commitSha = Environment.GetEnvironmentVariable("COMMIT_SHA");
        var buildNumberStr = Environment.GetEnvironmentVariable("BUILD_NUMBER");
        int.TryParse(buildNumberStr, out int buildNumber);
        
        // Apply migrations with version tracking
        var migrationResult = await migrationService.MigrateAsync(appVersion, buildNumber, commitSha);
        
        if (migrationResult.Success)
        {
            if (migrationResult.WasCreated)
            {
                logger.LogInformation("New database created and initialized successfully.");
            }
            else if (migrationResult.AppliedMigrations.Any())
            {
                logger.LogInformation($"Successfully applied {migrationResult.AppliedMigrations.Count} migration(s).");
            }
            else
            {
                logger.LogInformation("Database is up to date.");
            }
            
            logger.LogInformation($"Current database version: {migrationResult.CurrentVersion}");
        }
        else
        {
            logger.LogError($"Migration failed: {migrationResult.ErrorMessage}");
            throw new Exception($"Database migration failed: {migrationResult.ErrorMessage}");
        }
    }
    catch (Exception ex)
    {
        logger.LogCritical(ex, "Critical error during database initialization. Application startup failed.");
        throw;
    }
}

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseCors("AllowBlazorClient");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();