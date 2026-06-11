# EF Core Issue 01 - Could Not Load Assembly EMS.API

## Issue

Error while creating first migration:

Could not load assembly 'EMS.API'. Ensure it is referenced by the startup project 'EMS.Persistence'.

## Root Cause

Entity Framework Core requires both:

* Project containing DbContext
* Startup Project containing application configuration

The migration command was executed without correctly identifying the startup project.

## Resolution

Set EMS.API as Startup Project.

Execute migration using:

Add-Migration InitialCreate -StartupProject EMS.API

or

dotnet ef migrations add InitialCreate --project EMS.Persistence --startup-project EMS.API

## Learning

In multi-project solutions:

* DbContext may exist in Persistence Layer.
* Application startup exists in API Layer.
* EF Core requires access to both projects when generating migrations.
