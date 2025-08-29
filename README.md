# Auth-Enabled Web App

## Question 4

## Overview
This is a simple ASP.NET Core MVC app with authentication:
- Username/Password via ASP.NET Identity.
- SSO via Google.
- Protected page at /Protected showing "Hello, <Name>".
- Admins (seeded: admin@example.com / AdminPassword123!) can use password login.
- Non-admins must use SSO (enforced in login).
- Admins "manage access" via roles; extend with an admin panel.

## Setup
1. Update Google ClientId/Secret in Program.cs (from Google Developer Console).
2. Run `dotnet ef migrations add InitialCreate` and `dotnet ef database update` in Package Manager Console.
## Considerations
- **User Identity**: Stored in SQLite with hashing via Identity.
- **Access Enforcement**: [Authorize] attribute on ProtectedController.
- **Session Timeout**: Configurable via cookie expiration (default 14 days, customizable to 30 min).
- **Forced Logout**: Handled via SignInManager.SignOutAsync().
- **Audit Logging**: Could add middleware to log auth events.
- **Assumptions**: Minimal setup; Google for SSO. Used AI (Grok) for code snippets.

## Bonus: Authorization Expansion
- Add roles (e.g., "Viewer") in SeedData.
- Use [Authorize(Roles = "Admin")] on controllers/actions.
- Create an Admin controller with UserManager to list users and assign roles.
