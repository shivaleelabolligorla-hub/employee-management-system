# Sprint 02 - Step 05, 06, 07

## Repository Implementation, Service Layer and Dependency Injection

## Objective

Implement Repository Pattern, Service Layer Pattern and Dependency Injection registration.

---

## Repository Layer

Location:

EMS.Persistence

Repositories

### GenericRepository<T>

Purpose:

Provide reusable CRUD operations for all entities.

Implemented Methods:

- GetByIdAsync
- GetAllAsync
- AddAsync
- Update
- Delete
- SaveChangesAsync

Benefits:

- Code Reusability
- Reduced Duplication
- Consistent Data Access

---

### UserRepository

Purpose:

Handle User-specific database operations.

Implemented Methods:

- GetByUsernameAsync

Features:

- Loads Role information using Include()

Benefits:

- User-specific queries separated from generic CRUD operations.

---

## Service Layer

Location:

EMS.Application

Services

### UserService

Purpose:

Contains business logic related to User management.

Responsibilities:

- Create User
- Password Hashing
- User Validation
- Business Rule Enforcement

Benefits:

- Keeps Controllers Thin
- Centralizes Business Logic
- Improves Testability

---

## Password Security

Implemented:

BCrypt.Net

Purpose:

Hash passwords before storing them in database.

Example:

Input Password:

Admin123

Stored Value:

$2a$11$....

Benefits:

- Secure Password Storage
- Protection Against Database Leaks
- Industry Standard Practice

---

## Dependency Injection

Location:

EMS.API

Extensions

DependencyInjection.cs

Purpose:

Centralize service registrations.

Registered:

- IUserRepository → UserRepository
- IUserService → UserService

Benefits:

- Loose Coupling
- Easier Maintenance
- Cleaner Program.cs

---

## Architecture Flow

Client

↓

Controller

↓

Service Layer

↓

Repository Layer

↓

DbContext

↓

Database

---

## Learning Outcomes

- Repository Pattern
- Generic Repository
- Service Layer
- Dependency Injection
- Password Hashing
- Separation of Concerns

---

## Status

Completed Successfully