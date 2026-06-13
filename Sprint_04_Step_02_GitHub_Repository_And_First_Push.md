# Sprint 04 - Step 02

# GitHub Repository Creation and First Push

## Objective

Store the Employee Management System source code in a remote GitHub repository and establish a professional version control workflow.

---

# Prerequisites

Verified:

* Git Installed
* Git Repository Initialized
* Initial Commit Created
* GitHub Account Available

---

# Git Repository Initialization

Command:

```bash
git init
```

Purpose:

Convert the local project folder into a Git repository.

Result:

```text
.git folder created successfully.
```

---

# Verify Repository Status

Command:

```bash
git status
```

Result:

```text
Git detected all project files as untracked.
```

Purpose:

Verify repository status before tracking files.

---

# Git Ignore Configuration

Created:

```text
.gitignore
```

Purpose:

Prevent unnecessary files from being committed.

Ignored Files and Folders:

```text
.vs/
bin/
obj/
Logs/
publish/
*.user
*.suo
```

Benefits:

* Cleaner Repository
* Faster Clone Operations
* Reduced Repository Size
* Professional Development Practice

---

# Staging Files

Command:

```bash
git add .
```

Purpose:

Move all project files from the Working Directory to the Staging Area.

Result:

```text
All EMS project files added successfully.
```

---

# Creating Initial Commit

Command:

```bash
git commit -m "Initial EMS project setup with authentication module"
```

Purpose:

Create the first project snapshot.

Result:

```text
Initial commit created successfully.
```

---

# GitHub Repository Creation

Repository Name:

```text
employee-management-system
```

Visibility:

```text
Public
```

Description:

```text
Enterprise Employee Management System built using ASP.NET Core Web API, Layered Architecture, JWT Authentication, Entity Framework Core, Serilog, Azure DevOps CI/CD and IIS Deployment.
```

---

# Remote Repository Configuration

Command:

```bash
git remote add origin https://github.com/shivaleelabolligorla-hub/employee-management-system.git
```

Purpose:

Link local repository with GitHub repository.

Verification:

```bash
git remote -v
```

Result:

```text
origin https://github.com/shivaleelabolligorla-hub/employee-management-system.git (fetch)
origin https://github.com/shivaleelabolligorla-hub/employee-management-system.git (push)
```

---

# Branch Standardization

Command:

```bash
git branch -M main
```

Purpose:

Rename default branch to main.

Industry Standard Branch Names:

```text
main
develop
feature/*
release/*
hotfix/*
```

---

# Authentication Issue Encountered

Issue:

```text
403 Permission Denied
```

Error Message:

```text
Permission to repository denied.
```

Investigation Steps:

* Verified GitHub Repository URL
* Verified Repository Existence
* Verified Repository Ownership
* Verified Git Authentication

Root Cause:

```text
GitHub authentication session mismatch.
```

Resolution:

```text
Completed browser-based GitHub authentication and authorization.
```

---

# First Successful Push

Command:

```bash
git push -u origin main
```

Authentication Method:

```text
Browser Authentication
GitHub Authorization Flow
```

Result:

```text
Source code successfully uploaded to GitHub.
```

Repository Contents:

```text
EMS.API
EMS.Application
EMS.Infrastructure
EMS.Persistence
EMS.Tests
Ems.Domain
Documentation Files
Employee.Management.System.sln
```

---

# Real-Time Learning

## Local Repository

Stores:

* Source Code
* Commit History
* Branches

Location:

```text
Developer Machine
```

---

## Remote Repository

Stores:

* Source Code Backup
* Team Collaboration History
* Version Control Records

Location:

```text
GitHub
```

---

# Enterprise Workflow

```text
Developer
    ?
Git Add
    ?
Git Commit
    ?
Git Push
    ?
GitHub Repository
    ?
Pull Request
    ?
Code Review
    ?
CI Pipeline
    ?
Deployment
```

---

# Git Commands Learned

Initialize Repository:

```bash
git init
```

Check Status:

```bash
git status
```

Add Files:

```bash
git add .
```

Create Commit:

```bash
git commit -m "message"
```

Add Remote:

```bash
git remote add origin <repository-url>
```

Push Changes:

```bash
git push -u origin main
```

Verify Remote:

```bash
git remote -v
```

---

# Troubleshooting Experience

Issue:

```text
403 Permission Denied
```

Resolution Process:

1. Verified repository URL.
2. Verified repository ownership.
3. Verified GitHub authentication.
4. Re-authenticated through browser.
5. Re-ran git push command.
6. Successfully uploaded source code.

Learning:

```text
Many Git push failures are authentication-related rather than repository-related.
```

---

# Interview Topics Covered

* Git Basics
* GitHub Repository Management
* Local vs Remote Repository
* Git Authentication
* Git Push Process
* Version Control Workflow
* Branch Naming Standards

---

# Status

COMPLETED SUCCESSFULLY

---

# Next Step

Sprint 04 - Step 03

* Repository Cleanup
* Professional Documentation Structure
* Branch Strategy
* Azure DevOps Project Setup
* First CI Pipeline
