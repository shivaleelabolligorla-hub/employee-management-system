# Sprint 02 - Step 03 - Role Seeding and DTO Design

## Objective

Prepare authentication foundation by:

- Seeding default roles
- Creating Authentication DTOs
- Creating User DTOs

---

## Role Seeding

Default Roles:

1. Admin
2. HR
3. Employee

Implementation:

builder.HasData(
    new Role
    {
        Id = 1,
        RoleName = "Admin"
    },
    new Role
    {
        Id = 2,
        RoleName = "HR"
    },
    new Role
    {
        Id = 3,
        RoleName = "Employee"
    });

---

## Why Seed Data?

Certain data must always exist.

Examples:

- Roles
- Departments
- Countries
- Permissions

Benefits:

- Consistent Environments
- Faster Deployment
- Reduced Manual Setup

---

## DTO Structure

EMS.Application

DTOs

Authentication

- LoginRequestDto
- LoginResponseDto

User

- CreateUserDto
- UserResponseDto

---

## Authentication DTOs

### LoginRequestDto

Purpose:

Receive login credentials.

Fields:

- Username
- Password

---

### LoginResponseDto

Purpose:

Return authentication result.

Fields:

- Token
- Expiration

---

## User DTOs

### CreateUserDto

Purpose:

Receive user creation request.

Fields:

- Username
- Email
- Password
- RoleId

---

### UserResponseDto

Purpose:

Return user information.

Fields:

- Id
- Username
- Email
- RoleName

---

## Why DTO Pattern?

Incorrect:

Controller
↓

Entity

Correct:

Controller
↓

DTO
↓

Service
↓

Entity

Benefits:

- Hide Sensitive Data
- Input Validation
- API Versioning
- Loose Coupling
- Better Security

Example:

PasswordHash should never be returned to API consumers.

---

## Learning Outcomes

- DTO Pattern
- Authentication Models
- Request and Response Models
- Seed Data Strategy
- API Security Concepts

---

## Status

Completed Successfully