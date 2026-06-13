# Sprint 04 - Step 09

# Environment Configuration

## Objective

Understand environment-based configuration management in ASP.NET Core.

---

## Configuration Files

Application currently contains:

- appsettings.json
- appsettings.Development.json

Additional file created:

- appsettings.Production.json

---

## Purpose

Different environments require different configurations.

Examples:

- Connection Strings
- Logging Levels
- API URLs
- External Service Endpoints

---

## Environment Variable

ASP.NET Core uses:

ASPNETCORE_ENVIRONMENT

Possible Values:

- Development
- QA
- UAT
- Production

---

## Configuration Loading Order

Development Environment

appsettings.json
        +
appsettings.Development.json

---

Production Environment

appsettings.json
        +
appsettings.Production.json

---

## Production Logging Configuration

Created:

appsettings.Production.json

Example:

{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "Microsoft.AspNetCore": "Error"
    }
  }
}

---

## Benefits

- Environment Isolation
- Easier Maintenance
- No Code Changes Required
- Safer Production Deployments

---

## Learning Outcomes

- Environment-Specific Configuration
- ASPNETCORE_ENVIRONMENT
- Configuration Override Mechanism
- Production Configuration Strategy

---

## Status

Completed Successfully