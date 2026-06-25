# Implementation Rules

## Implementation Mode

Implementation mode is used only when the user explicitly asks to implement, solve, complete, fix, optimize, or rewrite a solution.

In implementation mode, the AI may:

* replace `throw new System.NotImplementedException();` with real solution logic
* add private helper methods inside the same `Solution.cs` file when they are useful for the solution
* add local functions when they make the implementation clearer
* update tests if the requested implementation exposes missing or weak coverage
* update the problem `README.md` when complexity or preferred status changes

In implementation mode, the AI must not:

* change repository structure unless explicitly requested
* add architecture
* add service or repository layers
* add dependency injection
* add logging
* add configuration files
* add interfaces unless explicitly requested
* add NuGet packages unless explicitly requested
* refactor unrelated problems
* rename existing files or directories unless explicitly requested

## Solution Scope

When given an implementation request:

* modify only the requested implementation
* keep the solution self-contained
* keep helper methods inside the same `Solution.cs` file
* keep tests shared when possible
* update approach-specific tests only when needed
* update the problem `README.md` if complexity or preferred status changes
* do not refactor unrelated approaches
* do not change repository structure unless explicitly requested
