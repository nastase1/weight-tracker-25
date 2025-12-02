#!/usr/bin/env pwsh
# Version Bump Script for Weight Tracker

param(
    [Parameter(Mandatory=$false)]
    [ValidateSet('major', 'minor', 'patch')]
    [string]$BumpType = 'patch',
    
    [Parameter(Mandatory=$false)]
    [switch]$Commit
)

$ErrorActionPreference = "Stop"
$VersionFile = "version.txt"

function Write-Header {
    param([string]$Text)
    Write-Host "`n========================================" -ForegroundColor Cyan
    Write-Host " $Text" -ForegroundColor Cyan
    Write-Host "========================================`n" -ForegroundColor Cyan
}

function Write-Success {
    param([string]$Text)
    Write-Host "$Text" -ForegroundColor Green
}

function Write-Error-Message {
    param([string]$Text)
    Write-Host "$Text" -ForegroundColor Red
}

function Write-Info {
    param([string]$Text)
    Write-Host "$Text" -ForegroundColor Yellow
}

function Get-CurrentVersion {
    if (-not (Test-Path $VersionFile)) {
        Write-Host "Version file not found. Creating with version 1.0.0" -ForegroundColor Yellow
        "VERSION=1.0.0`nBUILD_DATE=$(Get-Date -Format 'yyyy-MM-dd')`nLAST_COMMIT=Initial version" | Out-File -FilePath $VersionFile -Encoding utf8
        return "1.0.0"
    }
    
    $content = Get-Content $VersionFile
    $versionLine = $content | Where-Object { $_ -match "VERSION=" }
    
    if ($versionLine) {
        return $versionLine.Split('=')[1].Trim()
    }
    
    return "1.0.0"
}

function Update-Version {
    param(
        [string]$CurrentVersion,
        [string]$BumpType
    )
    
    $parts = $CurrentVersion.Split('.')
    $major = [int]$parts[0]
    $minor = [int]$parts[1]
    $patch = [int]$parts[2]
    
    switch ($BumpType) {
        'major' {
            $major++
            $minor = 0
            $patch = 0
        }
        'minor' {
            $minor++
            $patch = 0
        }
        'patch' {
            $patch++
        }
    }
    
    return "$major.$minor.$patch"
}

function Update-VersionFile {
    param([string]$NewVersion)
    
    $date = Get-Date -Format 'yyyy-MM-dd'
    $lastCommit = ""
    
    try {
        $lastCommit = git log -1 --pretty=format:"%s" 2>$null
    }
    catch {
        $lastCommit = "Version bump to $NewVersion"
    }
    
    $content = @"
# Version: $NewVersion
# This file tracks the application version and is automatically updated by CI/CD

VERSION=$NewVersion
BUILD_DATE=$date
LAST_COMMIT=$lastCommit
"@
    
    $content | Out-File -FilePath $VersionFile -Encoding utf8 -NoNewline
}

function Update-ProjectFiles {
    param([string]$Version)
    
    $projectFile = "WeightTracker25/WeightTracker.API/WeightTracker.API.csproj"
    
    if (Test-Path $projectFile) {
        $content = Get-Content $projectFile -Raw
        
        $content = $content -replace '<Version>[\d\.]+</Version>', "<Version>$Version</Version>"
        $content = $content -replace '<AssemblyVersion>[\d\.]+</AssemblyVersion>', "<AssemblyVersion>$Version.0</AssemblyVersion>"
        $content = $content -replace '<FileVersion>[\d\.]+</FileVersion>', "<FileVersion>$Version.0</FileVersion>"
        $content = $content -replace '<InformationalVersion>[\d\.]+</InformationalVersion>', "<InformationalVersion>$Version</InformationalVersion>"
        
        $content | Out-File -FilePath $projectFile -Encoding utf8 -NoNewline
        Write-Success "Updated $projectFile"
    }
}

# Main execution
try {
    Write-Header "Version Bump Tool"
    
    $currentVersion = Get-CurrentVersion
    Write-Info "Current version: $currentVersion"
    Write-Info "Bump type: $BumpType"
    
    $newVersion = Update-Version -CurrentVersion $currentVersion -BumpType $BumpType
    Write-Info "New version: $newVersion"
    
    # Update version file
    Update-VersionFile -NewVersion $newVersion
    Write-Success "Updated $VersionFile"
    
    # Update project files
    Update-ProjectFiles -Version $newVersion
    
    Write-Success "`nVersion bumped from $currentVersion to $newVersion"
    
    if ($Commit) {
        Write-Info "`nCommitting changes..."
        
        try {
            git add $VersionFile
            git add "WeightTracker25/WeightTracker.API/WeightTracker.API.csproj"
            git commit -m "Bump version to $newVersion"
            Write-Success "Changes committed"
            
            Write-Host "`nTo push changes, run:" -ForegroundColor Yellow
            Write-Host "git push origin main" -ForegroundColor Yellow
        }
        catch {
            Write-Host "Failed to commit: $_" -ForegroundColor Red
        }
    }
    else {
        Write-Host "`nTo commit these changes, run:" -ForegroundColor Yellow
        Write-Host ".\bump-version.ps1 -BumpType $BumpType -Commit" -ForegroundColor Yellow
        Write-Host "`nOr manually:" -ForegroundColor Yellow
        Write-Host "git add $VersionFile WeightTracker25/WeightTracker.API/WeightTracker.API.csproj" -ForegroundColor Yellow
        Write-Host "git commit -m 'Bump version to $newVersion'" -ForegroundColor Yellow
        Write-Host "git push origin main" -ForegroundColor Yellow
    }
    
    Write-Host "`n"
}
catch {
    Write-Host "Error: $_" -ForegroundColor Red
    exit 1
}
