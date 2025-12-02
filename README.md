Weight Traking App



#  Tutorial - Database Versioning & Migration System

## Table of Contents
1. [Daily Development Workflow](#daily-development-workflow)
2. [Database Migration Commands](#database-migration-commands)
3. [Version Management](#version-management)
4. [API Endpoints Usage](#api-endpoints-usage)

---


### 1. Making Database Schema Changes


**1. Create a migration**
```powershell
# In repository root
.\migrate.ps1 -Action create -Name AddLastLoginDateToUsers
```

This will:
- Generate migration files in `WeightTracker25/WeightTracker.Infrastructure/Migrations/`
- Create two files:
  - `YYYYMMDDHHMMSS_AddLastLoginDateToUsers.cs` (migration code)
  - `YYYYMMDDHHMMSS_AddLastLoginDateToUsers.Designer.cs` (metadata)


**2. Apply the migration**
```powershell
.\migrate.ps1 -Action apply
```

This will:
1. Create automatic backup: `backups/auto_backup_YYYYMMDD_HHMMSS.db`
2. Apply the migration
3. Record version info in database
4. Show you the result

**3. Run backend**
```powershell
cd WeightTracker25/WeightTracker.API
dotnet run
```

**The migration will also run automatically on startup!**

---

## Database Migration Commands

### Check Database Status
```powershell
.\migrate.ps1 -Action info
```

**Output:**
```
========================================
 Database Information
========================================

Applied Migrations:
  1 20251125104630_init
  2 20251130102836_AddVersionInfoTable

All Available Migrations:
20251125104630_init
20251130102836_AddVersionInfoTable

✓ Database exists (Size: 156.5 KB)
```

### Create New Migration
```powershell
.\migrate.ps1 -Action create -Name YourMigrationName
```

**Examples:**
```powershell
.\migrate.ps1 -Action create -Name AddUserPreferences
.\migrate.ps1 -Action create -Name UpdateWeightRecordIndex
.\migrate.ps1 -Action create -Name AddEmailVerificationField
```

### Apply Pending Migrations
```powershell
.\migrate.ps1 -Action apply
```

**What happens:**
1. Prerequisites check (dotnet, EF tools)
2. Creates backup (if database exists)
3. Applies all pending migrations
4. Records deployment in VersionHistory table
5. Shows updated database info

### Create Manual Backup
```powershell
.\migrate.ps1 -Action backup
```

**Output:**
```
✓ Backup created: backups/manual_backup_20251202_143022.db (Size: 156.5 KB)
```

### List All Backups
```powershell
.\migrate.ps1 -Action list-backups
```

**Output:**
```
========================================
 Available Backups
========================================

Backups (newest first):

  • manual_backup_20251202_143022.db
    Created: 2025-12-02 14:30:22 | Size: 156.5 KB
    
  • auto_backup_20251202_120015.db
    Created: 2025-12-02 12:00:15 | Size: 155.2 KB
    
  • auto_backup_20251201_183045.db
    Created: 2025-12-01 18:30:45 | Size: 154.8 KB

Total backups: 3
```

### Restore from Backup
```powershell
# First, list available backups
.\migrate.ps1 -Action restore

# Then restore a specific backup
.\migrate.ps1 -Action restore -BackupFile manual_backup_20251202_143022.db
```

**Interactive confirmation:**
```
WARNING: This will overwrite the current database!
Type 'yes' to confirm restoration: yes

✓ Current database backed up to: backups/pre-restore_20251202_143500.db
✓ Database restored from: manual_backup_20251202_143022.db
```

### Rollback Migration
```powershell
# Rollback to a specific migration
.\migrate.ps1 -Action rollback -Name 20251125104630_init

# Rollback all migrations (empty database)
.\migrate.ps1 -Action rollback -Name 0
```

**Interactive confirmation:**
```
WARNING: Rolling back to migration: 20251125104630_init
Type 'yes' to confirm rollback: yes

ℹ Creating backup before rollback...
✓ Backup created: backups/auto_backup_20251202_144000.db
✓ Rollback completed successfully
```

---

## Version Management

### Bump Application Version

**Increment Patch Version (1.0.0 → 1.0.1):**
```powershell
.\bump-version.ps1 -BumpType patch
```

**Increment Minor Version (1.0.1 → 1.1.0):**
```powershell
.\bump-version.ps1 -BumpType minor
```

**Increment Major Version (1.1.0 → 2.0.0):**
```powershell
.\bump-version.ps1 -BumpType major
```

**With Automatic Git Commit:**
```powershell
.\bump-version.ps1 -BumpType patch -Commit
```

This will:
1. Update `version.txt`
2. Update `WeightTracker.API.csproj`
3. Git commit: "Bump version to 1.0.1"
4. Ready to push

**Example Workflow:**
```powershell
# You've completed a new feature
.\bump-version.ps1 -BumpType minor -Commit
git push origin main

# CI/CD automatically:
# - Generates version: 1.1.0.142 (build #142)
# - Builds Docker images tagged with 1.1.0.142
# - Deploys with version tracking
```

---

## API Endpoints Usage

### Get Application Version

**Request:**
```bash
curl http://localhost:5028/api/version
```

**Response:**
```json
{
  "version": "1.0.0.0",
  "informationalVersion": "1.0.0",
  "fileVersion": "1.0.0.0",
  "buildDate": "2025-12-02T12:30:45Z",
  "environment": "Development"
}
```

### Get Database Information

**Request:**
```bash
curl http://localhost:5028/api/database/info
```

**Response:**
```json
{
  "database": {
    "canConnect": true,
    "isUpToDate": true,
    "currentVersion": "20251130102836_AddVersionInfoTable",
    "appliedMigrations": [
      "20251125104630_init",
      "20251130102836_AddVersionInfoTable"
    ],
    "pendingMigrations": []
  },
  "currentVersion": {
    "applicationVersion": "1.0.0.0",
    "databaseVersion": "20251130102836_AddVersionInfoTable",
    "deployedAt": "2025-12-02T10:15:30Z",
    "environment": "Development",
    "buildNumber": 0,
    "commitSha": "abc123def456",
    "hostName": "YOUR-MACHINE"
  }
}
```

### Get Version History

**Request:**
```bash
curl http://localhost:5028/api/database/version-history?count=5
```

**Response:**
```json
[
  {
    "versionId": 3,
    "applicationVersion": "1.0.0.0",
    "databaseVersion": "20251130102836_AddVersionInfoTable",
    "deployedAt": "2025-12-02T10:15:30Z",
    "environment": "Development",
    "buildNumber": 0,
    "commitSha": "abc123",
    "hostName": "DEV-MACHINE",
    "notes": "Deployment with 1.0.0.0 app version"
  },
  {
    "versionId": 2,
    "applicationVersion": "1.0.0.0",
    "databaseVersion": "20251125104630_init",
    "deployedAt": "2025-12-01T18:30:00Z",
    "environment": "Development",
    "buildNumber": 0,
    "commitSha": null,
    "hostName": "DEV-MACHINE",
    "notes": "Deployment with 1.0.0.0 app version"
  }
]
```

### List Database Backups

**Request:**
```bash
curl http://localhost:5028/api/database/backups
```

**Response:**
```json
[
  {
    "fileName": "manual_backup_20251202_143022.db",
    "fullPath": "/app/backups/manual_backup_20251202_143022.db",
    "createdDate": "2025-12-02T14:30:22Z",
    "sizeInBytes": 160256,
    "sizeInKB": 156.5
  },
  {
    "fileName": "auto_backup_20251202_120015.db",
    "fullPath": "/app/backups/auto_backup_20251202_120015.db",
    "createdDate": "2025-12-02T12:00:15Z",
    "sizeInBytes": 158976,
    "sizeInKB": 155.2
  }
]
```

### Create Manual Backup

**Request:**
```bash
curl -X POST http://localhost:5028/api/database/backup
```

**Response:**
```json
{
  "message": "Backup created successfully",
  "backupPath": "/app/backups/manual_backup_20251202_150000.db",
  "size": 160256,
  "timestamp": "2025-12-02T15:00:00Z"
}
```

### Validate Database Schema

**Request:**
```bash
curl http://localhost:5028/api/database/validate
```

**Response:**
```json
{
  "isValid": true,
  "message": "Database schema is valid"
}
```

---