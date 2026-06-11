# Sprint 03 - Step 01, 02, 03

## JWT Authentication Foundation

---

## Objective

Prepare the application for JWT-based authentication and authorization.

Implemented:

- JWT Configuration Model
- Authentication DTOs
- JWT Service Contract

---

## JWT Overview

JWT (JSON Web Token) is used for stateless authentication.

Authentication Flow:

User

↓

Login Request

↓

Credential Validation

↓

JWT Token Generation

↓

Client Stores Token

↓

Client Sends Token in Authorization Header

↓

Protected APIs Validate Token

---

## JwtSettings Configuration

Created:

JwtSettings.cs

Purpose:

Store JWT configuration values.

Properties:

- SecretKey
- Issuer
- Audience
- ExpiryMinutes

Benefits:

- Centralized Configuration
- Environment Flexibility
- Azure Key Vault Integration Ready

---

## appsettings.json

Added:

JwtSettings Section

Configuration:

- Secret Key
- Issuer
- Audience
- Expiry

Purpose:

Avoid hardcoded authentication values.

---

## Authentication DTOs

### LoginRequestDto

Purpose:

Receive user credentials.

Properties:

- Username
- Password

---

### LoginResponseDto

Purpose:

Return generated token information.

Properties:

- Token
- Expiration

---

## JWT Service Contract

Created:

IJwtService

Method:

GenerateToken(User user)

Purpose:

Separate token generation logic from business logic.

Benefits:

- Loose Coupling
- Testability
- Clean Architecture

---

## Security Concepts Introduced

Authentication

Verifies:

Who are you?

Authorization

Verifies:

What are you allowed to do?

JWT Token

Contains:

- User Identity
- Role Information
- Expiration

Claims

Used for:

- User Id
- Username
- Role

---

## Learning Outcomes

- JWT Fundamentals
- Authentication Flow
- Configuration Pattern
- Service Abstraction
- Security Architecture

---

## Status

Completed Successfully

Next:

JWT Token Generation
Authentication Service
Login API
Swagger Authorization