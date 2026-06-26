# Core Rules

## Purpose

This repository stores personal LeetCode solutions in C#.

The AI is allowed to:

* take a LeetCode problem link or problem statement
* create boilerplate code
* create real tests based on the problem examples
* create multiple implementation approaches for the same problem
* implement solution logic only when explicitly requested

The AI must not redesign the repository or introduce architecture.

## Modes

Boilerplate mode is the default when the user asks to create, add, scaffold, prepare, or set up a new problem or implementation approach.

Implementation mode is used only when the user explicitly asks to implement, solve, complete, fix, optimize, or rewrite a solution.

## Allowed Actions

The AI may:

* create a problem directory
* create an implementation approach directory
* create `Solution.cs` inside an implementation approach directory
* create `SolutionTestCases.cs`
* create `SolutionTests.cs`
* copy examples from the problem statement into tests
* add simple edge cases when they improve confidence or coverage
* add small helper methods in tests when needed
* keep solution files self-contained for easy LeetCode submission
* create additional implementation approach directories when explicitly requested

## Forbidden Actions

The AI must not:

* create `Solution.cs` directly in the problem root directory
* implement solution logic when asked to create boilerplate
* add partial implementations to boilerplate solutions
* add TODO algorithm bodies
* add placeholder return values
* add extra projects
* add dependency injection
* add logging
* add configuration files
* add service layers
* add repository layers
* add interfaces unless explicitly requested
* add NuGet packages unless explicitly requested
* rename existing files or directories unless explicitly requested
* refactor unrelated problems
* make tests pass by implementing solution logic unless explicitly requested
* modify `.sln`, `.slnx`, or `.csproj` files unless explicitly requested or required for compilation
* create `Best`, `Preferred`, `Optimal`, or `Main` implementation directories unless explicitly requested

Assume SDK-style project file globbing includes new `.cs` files.

## Code Style

Follow `.editorconfig`.

Do not define formatting or style rules in these rule files.

Use explicit types if that is already required by the repository style.

Do not introduce unrelated style changes.
