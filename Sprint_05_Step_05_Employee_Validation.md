# Sprint 05 - Step 05

## Employee Validation

### Objective

Validate Employee creation requests using FluentValidation.

---

## Validator Created

CreateEmployeeValidator

---

## Validation Rules

### EmployeeCode

* Required
* Max Length 20

### FirstName

* Required
* Max Length 100

### LastName

* Required
* Max Length 100

### Email

* Required
* Must be valid email format

### PhoneNumber

* Required

### Department

* Required

### Designation

* Required

### DateOfJoining

* Required

---

## Benefits

* Prevents invalid data
* Improves API quality
* Consistent error responses
* Enterprise validation pattern

---

## Status

Completed

Next Step:

Employee Entity Configuration and Database Migration
