# Sprint 02 - Step 01 - Authentication and User Management Database Design

## Objective

Design the core authentication and authorization entities required for the Employee Management System.

The goal is to establish a scalable and maintainable security model before implementing APIs.

---

## Business Requirement

The system should support:

* Authentication
* Authorization
* Role Based Access Control
* User Management

Supported Roles:

* Admin
* HR
* Employee

---

## Authentication vs Authorization

### Authentication

Authentication answers:

Who are you?

Example:

Username + Password

Result:

Identity is verified.

---

### Authorization

Authorization answers:

What are you allowed to do?

Example:

Admin can delete users.

Employee cannot delete users.

Result:

Permission is verified.

---

## Entity Design

### Role Entity

Purpose:

Represents a security role within the system.

Examples:

* Admin
* HR
* Employee

Properties:

* Id
* RoleName

---

### User Entity

Purpose:

Represents application login credentials and security information.

Properties:

* Id
* Username
* Email
* PasswordHash
* RoleId
* IsActive
* CreatedDate

Navigation:

* Role

---

### Employee Entity

Purpose:

Represents employee business information.

Properties:

* Id
* FirstName
* LastName
* Email
* Department
* Designation

---

## Why User and Employee Are Separate?

Incorrect Design:

Employee

* Name
* Email
* Password
* Role

Problems:

* Authentication mixed with business data.
* Difficult to manage security.
* Hard to audit.

---

Correct Design:

User

Authentication Information

?

Employee

Business Information

Benefits:

* Separation of Concerns
* Better Security
* Easier Maintenance
* Enterprise Ready Design

---

## Relationship Design

Role

1

?

Many

User

Meaning:

One Role can be assigned to multiple Users.

Examples:

Admin

* User A
* User B

Employee

* User C
* User D
* User E

---

## Database Tables Planned

Roles

* Id
* RoleName

Users

* Id
* Username
* Email
* PasswordHash
* RoleId
* IsActive
* CreatedDate

Employees

* Id
* FirstName
* LastName
* Email
* Department
* Designation

---

## ApplicationDbContext Updates

Added:

* DbSet<User>
* DbSet<Role>

Existing:

* DbSet<Employee>

---

## Enterprise Design Benefits

* Supports JWT Authentication
* Supports Role Based Authorization
* Supports Future Permission Management
* Supports User Deactivation
* Supports Auditing
* Supports Scalability

---

## Learning Outcomes

* Authentication Concepts
* Authorization Concepts
* Role Based Access Control
* Entity Relationship Design
* Security Focused Database Design

---

## Status

Completed Successfully

---

## Next Step

Entity Relationships and Fluent API Configuration
