# Sprint 02 - Step 13, 14, 15, 16

## Validation Integration, Role Verification and User API Testing

## Objective

Improve user creation workflow by:

* Enabling FluentValidation
* Adding Role Repository
* Implementing Business Validation
* Testing User Creation API

---

## Step 13 - FluentValidation Integration

### Purpose

Automatically validate incoming API requests before reaching business logic.

Implementation:

Program.cs

* Registered Validators
* Enabled FluentValidation pipeline

Benefits:

* Prevent invalid requests
* Reduce controller validation code
* Improve API consistency

---

## Validation Rules

CreateUserValidator

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

## Request Flow

Client

↓

FluentValidation

↓

Controller

↓

Service

Invalid requests stop before controller execution.

---

## Step 14 - Role Repository

Created:

IRoleRepository

RoleRepository

Purpose:

Provide Role-specific database access.

---

## Why Separate Repository?

Benefits:

* Separation of Concerns
* Better Testability
* Clear Data Access Layer

UserRepository handles User operations.

RoleRepository handles Role operations.

---

## Step 15 - Business Validation

Added Role Verification inside UserService.

Implementation:

Retrieve Role by RoleId.

If Role does not exist:

Throw Exception.

Example:

RoleId = 999

Result:

User creation blocked.

---

## Why Business Validation?

Validation Layer checks:

* Format
* Required Fields

Business Layer checks:

* Business Rules
* Data Integrity

Example:

RoleId greater than zero does not guarantee Role exists.

Service layer validates actual existence.

---

## Step 16 - User Creation Testing

Endpoint:

POST /api/users

Sample Request:

{
"username": "admin",
"email": "[admin@ems.com](mailto:admin@ems.com)",
"password": "Admin123",
"roleId": 1
}

Expected Response:

{
"id": 1,
"username": "admin",
"email": "[admin@ems.com](mailto:admin@ems.com)",
"roleName": "Admin"
}

---

## Password Verification

Database Check:

SELECT * FROM Users

Expected:

PasswordHash contains encrypted value.

Example:

$2a$11...

Actual passwords must never be stored.

---

## Architecture Achieved

DTO

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

## Learning Outcomes

* FluentValidation Integration
* Repository Pattern Expansion
* Business Rule Validation
* Service Layer Responsibilities
* Password Security
* API Testing

---

## Status

Completed Successfully

Sprint 02 Ready For Closure
