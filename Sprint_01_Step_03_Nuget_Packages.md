# Sprint 01 - Step 03 - NuGet Package Installation

## Objective

Install the required NuGet packages to support API development, database connectivity, authentication, logging, validation, mapping, and testing.

## Packages Installed

### EMS.API

#### Swashbuckle.AspNetCore

Purpose:
Generate Swagger/OpenAPI documentation for APIs.

Benefits:

* API Testing
* API Documentation
* Frontend Integration Support

#### Serilog.AspNetCore

Purpose:
Structured application logging.

Benefits:

* Centralized Logging
* Production Troubleshooting
* Monitoring

#### Serilog.Sinks.File

Purpose:
Store logs into text files.

Benefits:

* Error Investigation
* Audit Tracking

#### Microsoft.AspNetCore.Authentication.JwtBearer

Purpose:
JWT Authentication and Authorization.

Benefits:

* Secure APIs
* Token Based Authentication

---

### EMS.Persistence

#### Microsoft.EntityFrameworkCore

Purpose:
Object Relational Mapper (ORM) for database operations.

#### Microsoft.EntityFrameworkCore.SqlServer

Purpose:
SQL Server provider for Entity Framework Core.

#### Microsoft.EntityFrameworkCore.Tools

Purpose:
Supports migrations and database update commands.

---

### EMS.Application

#### AutoMapper

Purpose:
Object mapping between Entity and DTO classes.

Example:

Employee ? EmployeeResponseDto

#### AutoMapper.Extensions.Microsoft.DependencyInjection

Purpose:
Registers AutoMapper in Dependency Injection container.

#### FluentValidation.AspNetCore

Purpose:
Input validation.

Example:

* Required Fields
* Email Validation
* Business Rules

---

### EMS.Tests

#### xUnit

Purpose:
Unit Testing Framework.

#### Moq

Purpose:
Mock dependencies during testing.

#### FluentAssertions

Purpose:
Readable assertions in unit tests.

Example:

result.Should().NotBeNull();

---

## Benefits

* Reduced Boilerplate Code
* Improved Maintainability
* Better Validation
* Better Logging
* Easier Testing
* Enterprise Ready Foundation

## Status

Completed Successfully

## Lessons Learned

* NuGet packages should be installed only where required.
* Avoid installing all packages into every project.
* Each layer should have only the dependencies it needs.
