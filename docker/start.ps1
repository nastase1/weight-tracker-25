# Weight Tracker Docker Startup Script for Windows
param(
    [Parameter(Position=0)]
    [ValidateSet("dev", "prod", "down", "clean", "help")]
    [string]$Command = "prod"
)

Write-Host "Starting Weight Tracker Application..." -ForegroundColor Green

# Check if Docker is running
try {
    docker info | Out-Null
} catch {
    Write-Host "Docker is not running. Please start Docker and try again." -ForegroundColor Red
    exit 1
}

# Function to show usage
function Show-Usage {
    Write-Host "Usage: .\start.ps1 [dev|prod|down|clean|help]" -ForegroundColor Yellow
    Write-Host ""
    Write-Host "Commands:" -ForegroundColor Yellow
    Write-Host "  dev   - Start in development mode" -ForegroundColor White
    Write-Host "  prod  - Start in production mode (default)" -ForegroundColor White
    Write-Host "  down  - Stop all containers" -ForegroundColor White
    Write-Host "  clean - Stop containers and remove volumes" -ForegroundColor White
    Write-Host "  help  - Show this help message" -ForegroundColor White
    Write-Host ""
}

switch ($Command) {
    "dev" {
        Write-Host "Starting in Development mode..." -ForegroundColor Blue
        docker-compose -f docker-compose.dev.yml up --build -d
    }
    "prod" {
        Write-Host "Starting in Production mode..." -ForegroundColor Blue
        docker-compose up --build -d
    }
    "down" {
        Write-Host "Stopping containers..." -ForegroundColor Yellow
        docker-compose down
        docker-compose -f docker-compose.dev.yml down
    }
    "clean" {
        Write-Host "Cleaning up containers and volumes..." -ForegroundColor Yellow
        docker-compose down -v
        docker-compose -f docker-compose.dev.yml down -v
        docker system prune -f
    }
    "help" {
        Show-Usage
        exit 0
    }
    default {
        Write-Host "Unknown command: $Command" -ForegroundColor Red
        Show-Usage
        exit 1
    }
}

if ($Command -eq "dev" -or $Command -eq "prod") {
    Write-Host ""
    Write-Host "✅ Containers are starting up..." -ForegroundColor Green
    Write-Host ""
    Write-Host "Service URLs:" -ForegroundColor Cyan
    Write-Host "   Blazor Client: http://localhost:8080" -ForegroundColor White
    Write-Host "   API: http://localhost:5271" -ForegroundColor White
    Write-Host "   API Documentation: http://localhost:5271/swagger" -ForegroundColor White
    Write-Host ""
    Write-Host "To view container status: docker-compose ps" -ForegroundColor Gray
    Write-Host "To view logs: docker-compose logs -f" -ForegroundColor Gray
    Write-Host "To stop: .\start.ps1 down" -ForegroundColor Gray
}