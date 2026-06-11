# Sprint 03 - Step 12, 13, 14, 15, 16

## JWT Middleware and Authorization

---

# Objective

Secure APIs using JWT authentication and role-based authorization.

Implemented:

* JWT Authentication Middleware
* Authorization Middleware
* Protected Endpoints
* Swagger JWT Integration
* Role-Based Authorization
* Claims Access

---

# JWT Authentication Configuration

Registered:

AddAuthentication()

Authentication Scheme:

JwtBearer

Purpose:

Validate incoming JWT tokens.

Validation Includes:

* Issuer Validation
* Audience Validation
* Expiration Validation
* Signature Validation

---

# Token Validation Parameters

Configured:

* ValidateIssuer
* ValidateAudience
* ValidateLifetime
* ValidateIssuerSigningKey

Benefits:

* Prevent Token Tampering
* Prevent Expired Token Usage
* Prevent Invalid Token Usage

---

# Authentication Middleware

Registered:

app.UseAuthentication()

Purpose:

Read JWT token from Authorization header.

Example:

Authorization: Bearer eyJ...

Responsibilities:

* Validate Token
* Create Claims Principal
* Populate User Context

---

# Authorization Middleware

Registered:

app.UseAuthorization()

Purpose:

Evaluate authorization policies.

Examples:

[Authorize]

[Authorize(Roles = "Admin")]

---

# Protected Endpoint

Implemented:

UsersController

Attribute:

[Authorize]

Behavior:

Without Token:

401 Unauthorized

With Valid Token:

200 OK

---

# Swagger JWT Integration

Configured:

AddSecurityDefinition()

Security Scheme:

Bearer

Purpose:

Allow token entry directly from Swagger UI.

Result:

Authorize button displayed.

Benefits:

* Easier API Testing
* Faster Development Workflow

---

# Role-Based Authorization

Implemented:

[Authorize(Roles = "Admin")]

Purpose:

Restrict endpoint access by role.

Examples:

Admin

↓

Allowed

HR

↓

Forbidden

Employee

↓

Forbidden

---

# Authorization Responses

401 Unauthorized

Meaning:

User not authenticated.

Examples:

* Missing Token
* Invalid Token
* Expired Token

---

403 Forbidden

Meaning:

User authenticated but lacks permission.

Examples:

* HR accessing Admin endpoint
* Employee accessing Admin endpoint

---

# Claims Endpoint

Implemented:

GET /api/auth/me

Purpose:

Return current authenticated user information.

Claims Retrieved:

* UserId
* Username
* Role

Benefits:

* Profile APIs
* Audit Logging
* User Context Access

---

# Request Flow

Client

↓

JWT Token

↓

Authentication Middleware

↓

Authorization Middleware

↓

Controller

↓

Response

---

# Security Concepts Learned

Authentication

Answers:

Who are you?

---

Authorization

Answers:

What are you allowed to do?

---

Claims

Identity information stored inside token.

Examples:

* User Id
* Username
* Role

---

JWT Middleware

Validates incoming tokens.

---

Role-Based Security

Restricts access according to assigned role.

---

# Learning Outcomes

* JWT Validation
* Authentication Middleware
* Authorization Middleware
* Swagger Security
* Claims-Based Identity
* Role-Based Access Control
* Protected API Design

---

# Status

Completed Successfully

Sprint 03 Ready For Closure
