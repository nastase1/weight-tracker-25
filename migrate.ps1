#!/usr/bin/env pwsh
# Database Migration Management Script for Weight Tracker

param(
    [Parameter(Mandatory=$false)]
    [ValidateSet('create', 'apply', 'info', 'backup', 'restore', 'rollback', 'list-backups')]
    [string]$Action = 'info',
    
    [Parameter(Mandatory=$false)]
    [string]$Name = '',
    
    [Parameter(Mandatory=$false)]
    [string]$BackupFile = ''
)

$ErrorActionPreference = "Stop"
$InfrastructurePath = "WeightTracker25/WeightTracker.Infrastructure"
$DbPath = "weightTracker.db"

function Write-Header {
    param([string]$Text)
    Write-Host "`n========================================" -ForegroundColor Cyan
    Write-Host " $Text" -ForegroundColor Cyan
    Write-Host "========================================`n" -ForegroundColor Cyan
}

function Write-Success {
    param([string]$Text)
    Write-Host "OK: $Text" -ForegroundColor Green
}

function Write-ErrorCustom {
    param([string]$Text)
    Write-Host "ERROR: $Text" -ForegroundColor Red
}

function Write-Info {
    param([string]$Text)
    Write-Host "INFO: $Text" -ForegroundColor Yellow
}

function Test-Prerequisites {
    Write-Info "Checking prerequisites..."
    
    try {
        $dotnetVersion = dotnet --version
        Write-Success ".NET SDK found ($dotnetVersion)"
    }
    catch {
        Write-ErrorCustom ".NET SDK not found. Please install .NET 8.0 SDK"
        exit 1
    }
    
    try {
        $efVersion = dotnet ef --version
        Write-Success "EF Core tools found"
    }
    catch {
        Write-Info "EF Core tools not found. Installing..."
        dotnet tool install --global dotnet-ef
    }
    
    if (-not (Test-Path "WeightTracker25")) {
        Write-ErrorCustom "Must be run from repository root directory"
        exit 1
    }
}

function Get-DatabaseInfo {
    Write-Header "Database Information"
    
    Push-Location $InfrastructurePath
    try {
        Write-Host "Applied Migrations:" -ForegroundColor Cyan
        dotnet ef database update --list --startup-project "../WeightTracker.API" 2>&1 | Where-Object { $_ -match "^\s*\d" }
        
        Write-Host "`nAll Available Migrations:" -ForegroundColor Cyan
        dotnet ef migrations list --startup-project "../WeightTracker.API"
        
        if (Test-Path "../../$DbPath") {
            $dbSize = (Get-Item "../../$DbPath").Length
            $sizeKb = [math]::Round($dbSize/1KB, 2)
            Write-Success "Database exists (Size: $sizeKb KB)"
        }
        else {
            Write-Info "Database file not found"
        }
    }
    finally {
        Pop-Location
    }
}

function New-Migration {
    param([string]$MigrationName)
    
    if ([string]::IsNullOrWhiteSpace($MigrationName)) {
        Write-ErrorCustom "Migration name is required"
        exit 1
    }
    
    Write-Header "Creating Migration: $MigrationName"
    
    Push-Location $InfrastructurePath
    try {
        dotnet ef migrations add $MigrationName --startup-project "../WeightTracker.API" --context WeightTrackerDbContext
        Write-Success "Migration created"
    }
    catch {
        Write-ErrorCustom "Failed to create migration: $_"
        exit 1
    }
    finally {
        Pop-Location
    }
}

function Invoke-Migration {
    Write-Header "Applying Migrations"
    
    if (Test-Path $DbPath) {
        New-Backup -Auto
    }
    
    Push-Location $InfrastructurePath
    try {
        dotnet ef database update --startup-project "../WeightTracker.API" --context WeightTrackerDbContext
        Write-Success "Migrations applied successfully"
    }
    catch {
        Write-ErrorCustom "Migration failed: $_"
        exit 1
    }
    finally {
        Pop-Location
    }
}

function New-Backup {
    param([switch]$Auto)
    
    if (-not (Test-Path $DbPath)) {
        Write-ErrorCustom "Database not found"
        return
    }
    
    $timestamp = Get-Date -Format "yyyyMMdd_HHmmss"
    $backupDir = "backups"
    
    if (-not (Test-Path $backupDir)) {
        New-Item -ItemType Directory -Path $backupDir | Out-Null
    }
    
    $backupName = if ($Auto) { "auto_backup_$timestamp.db" } else { "manual_backup_$timestamp.db" }
    $backupPath = Join-Path $backupDir $backupName
    
    Copy-Item $DbPath $backupPath
    Write-Success "Backup created: $backupName"
    
    # Clean up old backups (keep last 10)
    $backups = Get-ChildItem $backupDir -Filter "*.db" | Sort-Object LastWriteTime -Descending
    if ($backups.Count -gt 10) {
        $backups | Select-Object -Skip 10 | ForEach-Object { Remove-Item $_.FullName }
    }
}

function Restore-Backup {
    param([string]$BackupFile)
    
    $backupDir = "backups"
    
    if ([string]::IsNullOrWhiteSpace($BackupFile)) {
        Write-Header "Available Backups"
        
        if (-not (Test-Path $backupDir)) {
            Write-Info "No backups found"
            return
        }
        
        $backups = Get-ChildItem $backupDir -Filter "*.db" | Sort-Object LastWriteTime -Descending
        
        $i = 1
        foreach ($backup in $backups) {
            $kb = [math]::Round($backup.Length/1KB, 2)
            $dt = Get-Date $backup.LastWriteTime -Format 'yyyy-MM-dd HH:mm:ss'
            # Simplificat pentru a evita erorile de parser
            Write-Host "[$i] $($backup.Name) | $dt | $kb KB"
            $i++
        }
        
        Write-Host "`nTo restore: .\migrate.ps1 -Action restore -BackupFile filename" -ForegroundColor Yellow
        return
    }
    
    $backupPath = Join-Path $backupDir $BackupFile
    
    if (-not (Test-Path $backupPath)) {
        Write-ErrorCustom "File not found: $backupPath"
        exit 1
    }
    
    Write-Host "WARNING: Overwriting current database!" -ForegroundColor Red
    $confirm = Read-Host "Type 'yes' to confirm"
    
    if ($confirm -ne 'yes') { return }
    
    try {
        Copy-Item $backupPath $DbPath -Force
        Write-Success "Restored from: $BackupFile"
    }
    catch {
        Write-ErrorCustom "Restore failed: $_"
        exit 1
    }
}

function Invoke-Rollback {
    param([string]$TargetMigration)
    
    if ([string]::IsNullOrWhiteSpace($TargetMigration)) {
        Write-ErrorCustom "Target migration name required"
        exit 1
    }
    
    if (Test-Path $DbPath) { New-Backup -Auto }
    
    Push-Location $InfrastructurePath
    try {
        dotnet ef database update $TargetMigration --startup-project "../WeightTracker.API" --context WeightTrackerDbContext
        Write-Success "Rollback complete"
    }
    catch {
        Write-ErrorCustom "Rollback failed: $_"
        exit 1
    }
    finally {
        Pop-Location
    }
}

function Show-Backups {
    Restore-Backup # Reuse logic
}

# --- Main Execution ---
try {
    Test-Prerequisites
    
    switch ($Action) {
        'create' { New-Migration -MigrationName $Name }
        'apply' { Invoke-Migration }
        'info' { Get-DatabaseInfo }
        'backup' { New-Backup }
        'restore' { Restore-Backup -BackupFile $BackupFile }
        'rollback' { Invoke-Rollback -TargetMigration $Name }
        'list-backups' { Show-Backups }
    }
}
catch {
    Write-ErrorCustom "Script failed: $_"
    exit 1
}