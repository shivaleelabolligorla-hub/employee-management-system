# Sprint 02 - Step 11 & 12

## Database Migration and Global Exception Middleware

## Objective

Update the database schema with User and Role entities and implement centralized exception handling.

---

## Migration Creation

Migration Name:

AddUserAndRoleTables

Purpose:

Create database tables for:

* Users
* Roles

and establish relationships.

---

## Database Update

Command Executed:

Update-Database

Result:

Database schema updated successfully.

---

## Tables Available

* Employees
* Users
* Roles
* __EFMigrationsHistory

---

## Seed Data Verification

Default roles inserted automatically.

Roles:

1 - Admin

2 - HR

3 - Employee

Purpose:

Provide default authorization roles.

---

## Why Seed Data?

Some data must always exist.

Examples:

* Roles
* Permissions
* Departments
* Countries

Benefits:

* Consistent environments
* Faster deployments
* Reduced manual setup

---

## Global Exception Middleware

Created:

GlobalExceptionMiddleware.cs

Purpose:

Handle all unhandled exceptions in a centralized location.

---

## Request Flow

Client

↓

Controller

↓

Service

↓

Repository

↓

Exception Occurs

↓

Global Exception Middleware

↓

Standardized Error Response

---

## Middleware Registration

Implemented Extension Method:

UseGlobalExceptionMiddleware()

Registered in Program.cs

Benefits:

* Cleaner Program.cs
* Reusable Configuration

---

## Error Response Standardization

Before Middleware:

Different exception formats.

After Middleware:

Consistent JSON response structure.

Example:

{
"message": "An unexpected error occurred."
}

---

## Benefits

* Centralized Error Handling
* Consistent API Responses
* Easier Troubleshooting
* Better User Experience

---

## Learning Outcomes

* EF Core Migrations
* Database Versioning
* Seed Data Strategy
* Custom Middleware
* Request Pipeline
* Exception Handling

---

## Status

Completed Successfully
