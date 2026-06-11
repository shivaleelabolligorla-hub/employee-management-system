# Sprint 01 - Step 02 - Project References

## Objective

Establish proper dependency flow between projects in the Employee Management System solution.

## Why Project References Are Required

Project references allow one project to access classes, interfaces, and functionality from another project.

This helps maintain a clean architecture and separation of concerns.

## Solution Structure

EmployeeManagementSystem

* EMS.API
* EMS.Application
* EMS.Domain
* EMS.Persistence
* EMS.Infrastructure
* EMS.Tests

## Dependency Flow

EMS.API

* EMS.Application
* EMS.Persistence
* EMS.Infrastructure

EMS.Application

* EMS.Domain

EMS.Persistence

* EMS.Domain
* EMS.Application

EMS.Infrastructure

* EMS.Application

## Architecture Principle

Dependencies should flow inward.

Outer layers can depend on inner layers.

Inner layers should never depend on outer layers.

### Correct

EMS.API → EMS.Application → EMS.Domain

### Incorrect

EMS.Domain → EMS.API

The Domain layer should remain independent and should not know anything about API, Database, or Infrastructure concerns.

## Benefits

* Separation of Concerns
* Better Maintainability
* Easier Unit Testing
* Reduced Coupling
* Improved Scalability
* Enterprise Architecture Compliance

## Learning Notes

### Solution

A Solution is a container that groups multiple projects together.

The Solution itself does not contain:

* Program.cs
* Controllers
* Services
* Database Logic

### Project

A Project contains actual code and functionality.

Examples:

* EMS.API
* EMS.Application
* EMS.Domain

### Program.cs

Only EMS.API contains Program.cs because it is the startup project.

Class Library projects such as:

* EMS.Domain
* EMS.Application
* EMS.Persistence
* EMS.Infrastructure

do not contain Program.cs.

## Status

Completed Successfully

## Challenges Faced

Initially created Application, Domain, Persistence, Infrastructure, and Tests as folders instead of separate projects.

## Resolution

Created each layer as an individual project and configured project references correctly.

## Lessons Learned

* Difference between Solution and Project
* Difference between Web API and Class Library
* Purpose of Project References
* Dependency Direction in Layered Architecture
* Why only the API project contains Program.cs
