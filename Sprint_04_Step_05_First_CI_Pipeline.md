# Sprint 04 - Step 05

# First CI Pipeline

## Objective

Create an automated Continuous Integration (CI) pipeline using Azure DevOps.

---

# What is CI?

Continuous Integration (CI) is the practice of automatically building and validating source code whenever changes are committed.

Flow:

Developer
    ↓
Git Push
    ↓
GitHub
    ↓
Azure DevOps Trigger
    ↓
Restore
    ↓
Build
    ↓
Test
    ↓
Artifact Generation

---

# Pipeline Trigger

```yaml
trigger:
- main
```

Purpose:

Automatically execute pipeline whenever code is pushed to main branch.

---

# Build Agent

```yaml
pool:
  vmImage: 'ubuntu-latest'
```

Purpose:

Use Microsoft-hosted Linux build agent.

---

# Build Configuration

```yaml
variables:
  buildConfiguration: 'Release'
```

Purpose:

Build application in Release mode.

---

# Pipeline Stages

## Install .NET SDK

Purpose:

Ensure .NET 8 SDK is available.

---

## Restore

Command:

dotnet restore

Purpose:

Download NuGet dependencies.

---

## Build

Command:

dotnet build

Purpose:

Compile application.

---

## Test

Command:

dotnet test

Purpose:

Execute automated tests.

---

## Publish

Command:

dotnet publish

Purpose:

Generate deployable output.

---

## Artifact

Purpose:

Store deployment package.

Artifact Name:

EMS_API

---

# CI Workflow

Developer
    ↓
Git Commit
    ↓
Git Push
    ↓
GitHub
    ↓
Azure DevOps
    ↓
Restore
    ↓
Build
    ↓
Test
    ↓
Publish
    ↓
Artifact

---

# Benefits

- Automated Validation
- Faster Feedback
- Consistent Builds
- Deployment Ready Artifacts
- Reduced Manual Effort

---

# Real-Time Industry Usage

Used in:

- Deloitte
- EY
- KPMG
- PwC
- Microsoft
- Amazon
- Google

Every code change triggers automated validation before deployment.

---

# Status

Completed Successfully

---

# Next Step

Create Deployment Pipeline

DEV Environment Deployment
QA Environment Deployment
PROD Environment Deployment