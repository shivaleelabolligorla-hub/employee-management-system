# Sprint 02 - Step 02 - Entity Configuration using Fluent API

## Objective

Configure database entities using Entity Framework Core Fluent API and establish relationships between entities.

---

## Why Fluent API?

Entity Framework Core supports:

1. Data Annotations
2. Fluent API

Example:

Data Annotation:

[Required]
[StringLength(100)]

Fluent API:

builder.Property(x => x.Username)
       .IsRequired()
       .HasMaxLength(100);

---

## Why We Chose Fluent API

Benefits:

- Cleaner Entities
- Better Separation of Concerns
- Centralized Configuration
- Enterprise Standard
- Easier Maintenance

---

## Configurations Created

### RoleConfiguration

Purpose:

Configure Role entity database mapping.

Configured:

- Table Name = Roles
- Primary Key = Id
- RoleName Required
- Max Length = 50

---

### UserConfiguration

Purpose:

Configure User entity database mapping.

Configured:

- Table Name = Users
- Primary Key = Id
- Username Required
- Email Required
- PasswordHash Required

---

## Relationship Configuration

Relationship:

Role

1

↓

Many

Users

Implementation:

builder.HasOne(x => x.Role)
       .WithMany(x => x.Users)
       .HasForeignKey(x => x.RoleId);

Meaning:

One Role can be assigned to many Users.

Example:

Admin

- User1
- User2

Employee

- User3
- User4

---

## ApplicationDbContext Enhancement

Added:

modelBuilder.ApplyConfigurationsFromAssembly(
    typeof(ApplicationDbContext).Assembly);

Benefits:

- Auto-discovers all configurations
- Cleaner DbContext
- No manual registration

---

## Learning Outcomes

- Fluent API
- IEntityTypeConfiguration
- One-To-Many Relationship
- Foreign Key Configuration
- Navigation Properties

---

## Status

Completed Successfully