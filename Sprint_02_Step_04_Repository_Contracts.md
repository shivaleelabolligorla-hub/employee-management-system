# Sprint 02 - Step 04 - Repository and Service Contracts

## Objective

Define contracts for data access and business operations before implementing functionality.

---

## Why Create Interfaces First?

Enterprise applications typically follow:

Controller
↓

Service Interface
↓

Service Implementation
↓

Repository Interface
↓

Repository Implementation
↓

Database

Benefits:

- Loose Coupling
- Easier Testing
- Better Maintainability
- Dependency Injection Support

---

## Repository Pattern

Purpose:

Abstract database access from business logic.

Without Repository:

Controller
↓

DbContext

Problems:

- Tight Coupling
- Difficult Unit Testing
- Business Logic Leakage

With Repository:

Controller
↓

Service

↓

Repository

↓

DbContext

Benefits:

- Cleaner Architecture
- Better Testing
- Easier Maintenance

---

## Interfaces Created

### IGenericRepository<T>

Common CRUD operations:

- GetByIdAsync
- GetAllAsync
- AddAsync
- Update
- Delete
- SaveChangesAsync

Purpose:

Avoid duplicate CRUD code across repositories.

---

### IUserRepository

Inherits:

IGenericRepository<User>

Additional Methods:

GetByUsernameAsync

Purpose:

User-specific database operations.

---

### IUserService

Business operations related to User management.

Current Method:

CreateUserAsync

Purpose:

Separate business rules from controllers.

---

## Generic Repository Benefits

Without Generic Repository:

- EmployeeRepository
- UserRepository
- DepartmentRepository
- RoleRepository

All contain repeated CRUD methods.

With Generic Repository:

Common functionality centralized.

Benefits:

- Less Code
- Consistent Implementation
- Easier Maintenance

---

## Learning Outcomes

- Repository Pattern
- Generic Repository Pattern
- Service Layer Pattern
- Interface Driven Development
- Dependency Inversion Principle

---

## Status

Completed Successfully