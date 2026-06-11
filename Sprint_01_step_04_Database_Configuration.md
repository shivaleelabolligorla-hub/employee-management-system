# Sprint 01 - Step 04 - Database Configuration and DbContext Setup

## Objective

Configure SQL Server connectivity, create the first domain entity, establish Entity Framework Core DbContext, and register database services in Dependency Injection.

---

## Tasks Completed

### 1. Database Creation

Database Name:

EmployeeManagementDB

Purpose:

Central database for Employee Management System.

Benefits:

* Persistent Data Storage
* Centralized Data Management
* Supports Entity Framework Core Migrations

---

### 2. Connection String Configuration

File:

EMS.API/appsettings.json

Connection String:

DefaultConnection

Purpose:

Provide database connection information to the application.

Benefits:

* Environment Specific Configuration
* Easier Deployment
* Centralized Database Settings

---

### 3. Employee Entity Creation

Location:

EMS.Domain/Entities

File:

Employee.cs

Properties:

* Id
* FirstName
* LastName
* Email

Purpose:

Represents an employee within the business domain.

Why Domain Layer?

Business entities should remain independent from:

* Controllers
* Database Implementations
* External Services

This follows Separation of Concerns.

---

### 4. ApplicationDbContext Creation

Location:

EMS.Persistence/Context

File:

ApplicationDbContext.cs

Purpose:

Acts as the bridge between Entity Framework Core and SQL Server.

Responsibilities:

* Database Connectivity
* Table Mapping
* Change Tracking
* Query Execution

Current DbSets:

* Employees

---

### 5. Dependency Injection Registration

File:

EMS.API/Program.cs

Registered:

ApplicationDbContext

Purpose:

Allow the application to request DbContext instances through Dependency Injection.

Benefits:

* Loose Coupling
* Better Testability
* Lifetime Management
* Industry Standard Practice

---

## Architecture Flow

User Request

↓

Controller

↓

Service Layer

↓

Repository Layer

↓

ApplicationDbContext

↓

SQL Server

---

## Learning Outcomes

### Entity

Represents a business object.

Example:

Employee

### DbContext

Represents a session with the database.

Responsible for:

* Reading Data
* Writing Data
* Tracking Changes

### Dependency Injection

Framework automatically provides required dependencies at runtime.

Example:

ApplicationDbContext injected into repositories.

### Connection String

Stores database connectivity information separately from application code.

---

## Challenges Faced

Understanding where entities and DbContext should be placed within a layered architecture.

Resolution:

* Entities belong to Domain Layer.
* DbContext belongs to Persistence Layer.
* Registration occurs in API Layer.

---

## Best Practices Learned

* Keep entities inside Domain.
* Keep database implementation inside Persistence.
* Register services only through Dependency Injection.
* Never hardcode database connections in business logic.

---

## Status

Completed Successfully

---

## Sprint Progress

Completed:

✔ Solution Structure

✔ Project References

✔ NuGet Packages

✔ Database Configuration

✔ Employee Entity

✔ ApplicationDbContext

✔ Dependency Injection Registration

Next Step:

Entity Framework Core Migration and Database Initialization
