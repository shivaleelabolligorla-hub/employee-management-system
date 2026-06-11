# Sprint 03 - Step 04, 05, 06, 07

## JWT Service and Authentication Foundation

---

## Objective

Implement the foundation required for JWT-based authentication.

Implemented:

- JWT Token Generator
- JWT Configuration Registration
- Dependency Injection Registration
- Authentication Service Contract

---

# JWT Service Implementation

Location:

EMS.Infrastructure

Security

JwtService.cs

Purpose:

Generate JWT access tokens for authenticated users.

Responsibilities:

- Create Claims
- Create Security Key
- Create Signing Credentials
- Create JWT Token
- Return Serialized Token

---

## Why Infrastructure?

JWT generation is not business logic.

It is a technical implementation.

Examples of Infrastructure Concerns:

- JWT Authentication
- Email Sending
- SMS Providers
- File Storage
- Azure Blob Storage
- Redis Cache

Benefits:

- Better Separation of Concerns
- Easier Testing
- Cleaner Architecture

---

# Claims Implementation

Added Claims:

## NameIdentifier

Stores:

User Id

Example:

1

---

## Name

Stores:

Username

Example:

admin

---

## Role

Stores:

Role Name

Example:

Admin

Purpose:

Used for Role-Based Authorization.

---

# JWT Security Key

Created using:

SymmetricSecurityKey

Secret Key retrieved from:

JwtSettings

Benefits:

- Centralized Configuration
- Environment Specific Values
- Production Readiness

---

# Signing Credentials

Algorithm:

HmacSha256

Purpose:

Digitally sign token.

Benefits:

- Prevents Token Tampering
- Ensures Token Integrity

---

# Token Expiration

Configured using:

ExpiryMinutes

Current Flow:

Current UTC Time

+

Configured Expiry

↓

Expiration Timestamp

Benefits:

- Improved Security
- Automatic Session Expiry

---

# JwtSettings Registration

Registered:

JwtSettings

Source:

appsettings.json

Benefits:

- Avoid Hardcoded Secrets
- Easier Environment Configuration
- Azure Key Vault Ready

---

# Dependency Injection Registration

Registered:

IJwtService

↓

JwtService

Purpose:

Allow application layer to consume JWT functionality through abstraction.

Benefits:

- Loose Coupling
- Dependency Inversion Principle
- Easier Unit Testing

---

# Authentication Service Contract

Created:

IAuthService

Method:

LoginAsync(LoginRequestDto dto)

Purpose:

Define authentication workflow contract.

Responsibilities:

- Validate Credentials
- Generate JWT Token
- Return Login Response

Implementation planned in next step.

---

# Architecture Flow

Client

↓

Login Request

↓

AuthService

↓

User Repository

↓

Password Verification

↓

JwtService

↓

JWT Token

↓

Client

---

# Security Concepts Learned

## Authentication

Answers:

Who are you?

---

## Authorization

Answers:

What are you allowed to do?

---

## Claims

Information stored inside token.

Examples:

- User Id
- Username
- Role

---

## JWT

Stateless Authentication Mechanism.

Benefits:

- Scalable
- Fast
- API Friendly

---

# Learning Outcomes

- JWT Fundamentals
- Claims-Based Identity
- Security Layer Design
- Dependency Inversion
- Infrastructure Layer Responsibilities
- Authentication Architecture

---

# Status

Completed Successfully

Next:

- Login Implementation
- Credential Validation
- Token Generation
- Authentication Controller
- Swagger Authorization
- Protected Endpoints