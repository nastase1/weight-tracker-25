using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WeightTracker.Client;
using WeightTracker.Client.Services;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configure HttpClient for API calls
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5028/") });

// Add services
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<WeightService>();
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<AdminService>();

await builder.Build().RunAsync();
