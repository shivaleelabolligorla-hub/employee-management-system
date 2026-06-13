# Sprint 04 - Step 08

# IIS Foundation And Website Deployment

## Objective

Deploy EMS API artifact generated from Azure DevOps to IIS and host the application locally.

---

## Deployment Architecture

Developer
    ↓
GitHub
    ↓
Azure DevOps CI Pipeline
    ↓
Artifact
    ↓
IIS Website
    ↓
Running Application

---

## Deployment Folder

Created:

C:\Deployments\EMS_API_DEV

Purpose:

Store published application files generated from Azure DevOps artifact.

---

## Artifact Contents

Observed:

- EMS.API.dll
- EMS.Application.dll
- EMS.Persistence.dll
- EMS.Infrastructure.dll
- EMS.Domain.dll
- web.config
- appsettings.json
- appsettings.Development.json

---

## IIS Concepts

### Website

Represents the hosted application.

Website Name:

EMS_API_DEV

---

### Application Pool

Dedicated runtime process for application execution.

Application Pool Name:

EMS_API_DEV_POOL

Configuration:

- Pipeline Mode: Integrated
- CLR Version: No Managed Code

---

### Physical Path

Application deployment location.

Path:

C:\Deployments\EMS_API_DEV

---

## Website Binding

Protocol:

HTTP

Port:

5001

Example URL:

http://localhost:5001

---

## Why No Managed Code?

ASP.NET Core runs using:

IIS
    ↓
ASP.NET Core Module
    ↓
Kestrel
    ↓
Application

Therefore IIS does not directly host CLR code.

Recommended setting:

No Managed Code

---

## Validation

Website created successfully.

Application Pool started successfully.

Application accessed through IIS URL successfully.

---

## Learning Outcomes

- IIS Website Creation
- Application Pool Configuration
- IIS Hosting Fundamentals
- Artifact Deployment
- ASP.NET Core Hosting Model

---

## Status

Completed Successfully