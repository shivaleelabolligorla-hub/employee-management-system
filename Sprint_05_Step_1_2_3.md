# Sprint 05 - Step 01, 02 & 03

## Employee Module Planning and Design

---

# Objective

Prepare Azure DevOps Sprint Planning and design the Employee Module before implementation.

---

# Step 01 - Azure DevOps Board Setup

## Epic Created

Employee Management Module

### Purpose

Represents the complete Employee Management functionality of the system.

---

## Feature Created

Employee CRUD Operations

### Purpose

Represents all Employee Create, Read, Update and Delete operations.

---

## User Stories Created

1. Create Employee API
2. Get Employee By Id API
3. Get All Employees API
4. Update Employee API
5. Delete Employee API

---

# Hierarchy

Epic
└── Employee Management Module

```
Feature
└── Employee CRUD Operations

    Stories
    ├── Create Employee API
    ├── Get Employee By Id API
    ├── Get All Employees API
    ├── Update Employee API
    └── Delete Employee API
```

---

# Step 02 - Sprint Planning

## Sprint Created

Sprint 5

### Purpose

Track Employee Module implementation work using Agile methodology.

---

## Stories Assigned To Sprint 5

1. Create Employee API
2. Get Employee By Id API
3. Get All Employees API
4. Update Employee API
5. Delete Employee API

---

## Azure DevOps Concepts Learned

* Epic
* Feature
* User Story
* Task
* Sprint
* Iteration Path
* Parent Child Relationship
* Sprint Assignment

---

# Step 03 - Employee Module Design

## Task Created

Design Employee Entity

Parent Story:

Create Employee API

---

## Initial Employee Entity Review

Existing Fields:

* Id
* FirstName
* LastName
* Email
* Department
* Designation

---

## Planned Employee Entity Version 1

Fields:

* Id
* EmployeeCode
* FirstName
* LastName
* Email
* PhoneNumber
* Department
* Designation
* DateOfJoining
* IsActive
* CreatedOn
* ModifiedOn

---

## Design Decisions

### Primary Key

Using Integer Id for current implementation.

Reason:

* Simpler learning path
* Easier debugging
* Suitable for monolithic architecture

---

## Sprint Status

Sprint 5 Started

Current Progress:

Completed:

* Azure DevOps Board Setup
* Epic Creation
* Feature Creation
* User Story Creation
* Sprint Creation
* Sprint Assignment
* Employee Entity Design

Next Step:

Create Employee DTOs
