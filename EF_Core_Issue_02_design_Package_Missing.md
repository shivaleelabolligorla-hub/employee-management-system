# EF Core Issue 02 - Design Package Missing

## Issue

Unable to create migration.

Error indicated that the startup project
EMS.API was missing Entity Framework Core Design package.

## Root Cause

EF Core migration tooling requires
Microsoft.EntityFrameworkCore.Design
in the startup project.

## Resolution

Installed:

Microsoft.EntityFrameworkCore.Design

into EMS.API project.

## Learning

In multi-project solutions:

- DbContext may exist in Persistence Layer.
- Startup configuration exists in API Layer.
- EF migration tooling requires design-time services from the startup project.