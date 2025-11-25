using Microsoft.EntityFrameworkCore;
using WeightTracker.Domain.Entities;
using System.Security.Cryptography;
using System.Text;

namespace WeightTracker.Infrastructure.Context
{
    public class WeightTrackerDbContext : DbContext
    {
        public WeightTrackerDbContext(DbContextOptions<WeightTrackerDbContext> options)
            : base(options)
        {
        }

        public WeightTrackerDbContext()
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Records> Records { get; set; }
        public DbSet<PasswordResetToken> PasswordResetTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);
                entity.Property(e => e.IsAdmin).HasDefaultValue(false);
                entity.Property(e => e.Username).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.PasswordHash).IsRequired();
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("datetime('now')");
            });

            modelBuilder.Entity<Records>(entity =>
            {
                entity.HasKey(e => e.RecordId);
                entity.Property(e => e.Weight).HasColumnType("decimal(5,2)");
                entity.Property(e => e.Height).HasColumnType("decimal(5,2)");
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("datetime('now')");

                entity.HasOne(e => e.User)
                    .WithMany()
                    .HasForeignKey(e => e.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<PasswordResetToken>(entity =>
            {
                entity.HasKey(e => e.TokenId);
                entity.Property(e => e.ResetCode).IsRequired().HasMaxLength(6);
                entity.Property(e => e.ExpiryDate).IsRequired();
                entity.Property(e => e.IsUsed).HasDefaultValue(false);

                entity.HasOne(e => e.User)
                    .WithMany()
                    .HasForeignKey(e => e.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // Seed data
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Hash pentru parola "password123"
            string passwordHash = BCrypt.Net.BCrypt.HashPassword("password123");

            // Generate Guids for users
            var user1Id = Guid.NewGuid();
            var user2Id = Guid.NewGuid();
            var user3Id = Guid.NewGuid();
            var adminId = Guid.NewGuid();

            // Seed Users
            var users = new[]
            {
                new Users
                {
                    UserId = user1Id,
                    IsAdmin = false,
                    Username = "john_doe",
                    Email = "john.doe@example.com",
                    PasswordHash = passwordHash,
                    CreatedAt = DateTime.UtcNow.AddMonths(-6)
                },
                new Users
                {
                    UserId = user2Id,
                    IsAdmin = false,
                    Username = "jane_smith",
                    Email = "jane.smith@example.com",
                    PasswordHash = passwordHash,
                    CreatedAt = DateTime.UtcNow.AddMonths(-4)
                },
                new Users
                {
                    UserId = user3Id,
                    IsAdmin = false,
                    Username = "mike_johnson",
                    Email = "mike.johnson@example.com",
                    PasswordHash = passwordHash,
                    CreatedAt = DateTime.UtcNow.AddMonths(-2)
                },
                new Users
                {
                    UserId = adminId,
                    IsAdmin = true,
                    Username = "admin_user",
                    Email = "admin@email.com",
                    PasswordHash = passwordHash,
                    CreatedAt = DateTime.UtcNow.AddMonths(-1)
                }
            };

            modelBuilder.Entity<Users>().HasData(users);

            // Seed Records pentru John Doe - 3 luni de date
            var recordsJohn = new List<Records>();
            decimal startWeight = 85.5m;
            decimal startHeight = 175m;
            var startDate = DateTime.UtcNow.AddMonths(-3);

            for (int i = 0; i < 90; i += 3) // O înregistrare la 3 zile
            {
                var weight = startWeight - (i * 0.15m) + (decimal)(new Random(i).NextDouble() * 2 - 1);
                recordsJohn.Add(new Records
                {
                    RecordId = Guid.NewGuid(),
                    UserId = user1Id,
                    RecordDate = startDate.AddDays(i),
                    Weight = Math.Round(weight, 2),
                    Height = startHeight,
                    CreatedAt = startDate.AddDays(i)
                });
            }

            // Seed Records pentru Jane Smith - 2 luni de date
            var recordsJane = new List<Records>();
            startWeight = 68.2m;
            startHeight = 165m;
            startDate = DateTime.UtcNow.AddMonths(-2);

            for (int i = 0; i < 60; i += 4) // O înregistrare la 4 zile
            {
                var weight = startWeight + (i * 0.08m) + (decimal)(new Random(i + 1000).NextDouble() * 1.5 - 0.75);
                recordsJane.Add(new Records
                {
                    RecordId = Guid.NewGuid(),
                    UserId = user2Id,
                    RecordDate = startDate.AddDays(i),
                    Weight = Math.Round(weight, 2),
                    Height = startHeight,
                    CreatedAt = startDate.AddDays(i)
                });
            }

            // Seed Records pentru Mike Johnson - 1 lună de date
            var recordsMike = new List<Records>();
            startWeight = 92.8m;
            startHeight = 182m;
            startDate = DateTime.UtcNow.AddMonths(-1);

            for (int i = 0; i < 30; i += 2) // O înregistrare la 2 zile
            {
                var weight = startWeight - (i * 0.25m) + (decimal)(new Random(i + 2000).NextDouble() * 2.5 - 1.25);
                recordsMike.Add(new Records
                {
                    RecordId = Guid.NewGuid(),
                    UserId = user3Id,
                    RecordDate = startDate.AddDays(i),
                    Weight = Math.Round(weight, 2),
                    Height = startHeight,
                    CreatedAt = startDate.AddDays(i)
                });
            }

            modelBuilder.Entity<Records>().HasData(recordsJohn);
            modelBuilder.Entity<Records>().HasData(recordsJane);
            modelBuilder.Entity<Records>().HasData(recordsMike);
        }
    }
}