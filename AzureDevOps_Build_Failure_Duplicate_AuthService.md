# Azure DevOps Build Failure - Duplicate AuthService

## Issue

Azure DevOps pipeline failed during build.

Error:

CS0101: Namespace already contains a definition for AuthService.

CS0111: Type AuthService already defines a member called AuthService.

CS0111: Type AuthService already defines a member called LoginAsync.

---

## Root Cause

UserService.cs accidentally contained AuthService implementation.

Both files contained:

```csharp
public class AuthService : IAuthService
```

This resulted in duplicate class definitions within the same namespace.

---

## Resolution

Restored UserService.cs with correct implementation:

```csharp
public class UserService : IUserService
```

and retained AuthService.cs as:

```csharp
public class AuthService : IAuthService
```

---

## Learning

CI pipelines compile code from source control, not local memory.

A local fix must be committed and pushed to ensure pipeline success.

---

## Status

Resolved Successfully
