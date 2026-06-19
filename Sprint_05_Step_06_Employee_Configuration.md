# Sprint 05 - Step 06

## Employee Entity Configuration

### Objective

Configure Employee entity using Entity Framework Fluent API.

---

## Configuration Created

EmployeeConfiguration.cs

---

## Table

Employees

---

## Constraints

### EmployeeCode

* Required
* Max Length 20
* Unique

### FirstName

* Required
* Max Length 100

### LastName

* Required
* Max Length 100

### Email

* Required
* Max Length 150
* Unique

### Department

* Required

### Designation

* Required

### DateOfJoining

* Required

### IsActive

* Default Value = true

---

## Benefits

* Database Constraints
* Better Performance
* Data Integrity
* Clean Architecture

---

## Status

Completed

Next Step:

Employee Database Migration
