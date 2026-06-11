# Sprint 03 - Step 08, 09, 10, 11

## Login Authentication Module

---

# Objective

Implement user authentication using:

- Username Validation
- Password Verification
- JWT Token Generation
- Authentication API

---

# User Repository Enhancement

## New Method

GetByUsernameAsync()

Purpose:

Retrieve user information required for login.

Implementation:

- Search by Username
- Include Role Information

Reason:

JWT token requires Role claim.

---

# Repository Flow

AuthService

↓

UserRepository

↓

GetByUsernameAsync()

↓

Database

---

# AuthService Implementation

Created:

AuthService.cs

Purpose:

Handle authentication workflow.

Responsibilities:

- Validate Username
- Verify Password
- Generate JWT Token
- Return Login Response

---

# Login Workflow

Client

↓

Login Request

↓

AuthService

↓

Get User By Username

↓

Verify Password

↓

Generate JWT

↓

Return Token

---

# User Validation

Implementation:

Check if user exists.

Example:

Username = admin

If user not found:

Throw Exception

Response:

Invalid username or password

---

# Password Verification

Implementation:

BCrypt.Verify()

Purpose:

Compare entered password with stored password hash.

Benefits:

- Secure Authentication
- No Plain Text Password Comparison

Example:

Input:

Admin123

Stored:

$2a$11...

Result:

True

---

# JWT Generation

Delegated to:

IJwtService

Implementation:

JwtService

Benefits:

- Separation of Concerns
- Cleaner Service Layer
- Dependency Inversion

---

# Login Response

Response DTO:

LoginResponseDto

Properties:

- Token
- Expiration

Example:

{
  "token": "eyJhbGciOi...",
  "expiration": "2026-06-09T12:00:00"
}

---

# Dependency Injection

Registered:

IAuthService

↓

AuthService

Purpose:

Enable controller access through abstraction.

Benefits:

- Loose Coupling
- Testability
- Maintainability

---

# Authentication Controller

Created:

AuthController

Endpoint:

POST /api/auth/login

Purpose:

Receive login requests.

Responsibilities:

- Accept Credentials
- Call AuthService
- Return JWT Token

Controller remains thin.

Business logic stays inside service layer.

---

# Security Concepts Learned

Authentication

Answers:

Who are you?

Example:

Username + Password

---

Password Hashing

Purpose:

Protect passwords in database.

Implementation:

BCrypt

---

Password Verification

Purpose:

Verify credentials without exposing passwords.

Implementation:

BCrypt.Verify()

---

JWT Token

Purpose:

Represent authenticated identity.

Contains:

- User Id
- Username
- Role

---

# Architecture Flow

Client

↓

AuthController

↓

AuthService

↓

UserRepository

↓

Database

↓

JwtService

↓

JWT Token

↓

Client

---

# Learning Outcomes

- Authentication Workflow
- BCrypt Verification
- JWT Token Generation
- Service Layer Authentication
- Repository Query Design
- Dependency Injection

---

# Status

Completed Successfully

Next:

JWT Middleware
Swagger Authentication
Authorize Attribute
Role-Based Authorization
Protected Endpoints