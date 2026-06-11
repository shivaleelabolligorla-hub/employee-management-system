# Sprint 02 - Step 08, 09, 10

## AutoMapper, FluentValidation and User Controller

## Objective

Implement object mapping, request validation and the first business API endpoint.

---

## AutoMapper

### Purpose

Automatically map objects between:

* DTOs
* Entities

Example:

CreateUserDto

↓

User

User

↓

UserResponseDto

---

## Why AutoMapper?

Without AutoMapper:

Manual property assignment required.

Example:

user.Username = dto.Username;

user.Email = dto.Email;

user.RoleId = dto.RoleId;

For large entities this becomes difficult to maintain.

---

## UserProfile

Created:

UserProfile.cs

Mappings:

CreateUserDto → User

User → UserResponseDto

Special Mapping:

Role.RoleName → UserResponseDto.RoleName

---

## Benefits

* Reduced Boilerplate Code
* Cleaner Service Layer
* Centralized Mapping Logic
* Easier Maintenance

---

## UserService Refactoring

Before:

Manual object mapping.

After:

AutoMapper handles object conversion.

Benefits:

* Cleaner Business Logic
* Better Readability
* Less Repetitive Code

---

## FluentValidation

### Purpose

Validate incoming requests before business logic execution.

Created:

CreateUserValidator.cs

Validation Rules:

Username

* Required
* Maximum Length 100

Email

* Required
* Valid Email Format

Password

* Required
* Minimum Length 6

RoleId

* Must be greater than zero

---

## Why Validation?

Prevents invalid data from entering the application.

Example Invalid Request:

{
"username": "",
"email": "abc",
"password": "1"
}

Validation fails before reaching database operations.

---

## Benefits

* Data Integrity
* Better User Experience
* Cleaner Business Logic
* Reduced Runtime Errors

---

## User Controller

Created:

UsersController.cs

Endpoint:

POST /api/users

Purpose:

Create application users.

Flow:

Client

↓

UsersController

↓

UserService

↓

UserRepository

↓

Database

---

## Architecture Achieved

CreateUserDto

↓

Validation

↓

Controller

↓

Service

↓

Repository

↓

DbContext

↓

SQL Server

---

## Design Principles Applied

* Separation of Concerns
* Dependency Injection
* Repository Pattern
* Service Layer Pattern
* DTO Pattern
* Validation Layer
* Object Mapping

---

## Learning Outcomes

* AutoMapper Configuration
* DTO Mapping
* FluentValidation
* API Controller Design
* Request Processing Pipeline

---

## Status

Completed Successfully

---

## Next Step

Database Migration for Users and Roles

Global Exception Middleware

End-to-End User Creation Testing
