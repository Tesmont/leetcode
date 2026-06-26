# AGENTS.md

## Purpose

This repository stores personal LeetCode solutions in C#.

This file is the required entry point for any work under `csharp/`.
Read the referenced rule files before reading, creating, or editing matching files.

## Required Rule Files

Always read:

* `.agents/core.md`
* `.agents/structure.md`

Read based on the task:

* `.agents/naming-signatures.md` when creating or editing source, tests, namespaces, problem directories, or public APIs
* `.agents/boilerplate.md` when creating, adding, scaffolding, preparing, or setting up a new problem or implementation approach
* `.agents/implementation.md` when implementing, solving, completing, fixing, optimizing, or rewriting a solution
* `.agents/tests.md` when creating or editing tests
* `.agents/workflows.md` when following an end-to-end repository workflow

If a task crosses multiple areas, read every matching file. If unsure, read all files in `.agents/`.

## Priority

When rules conflict, use this priority order:

* correctness of structure
* official LeetCode C# public API compatibility
* runnable tests
* self-contained LeetCode copy-paste solutions
* stable implementation directories
* minimal boilerplate
* readability

## Default Behavior

If unsure:

* generate minimal boilerplate
* use `Initial` as the first implementation approach name
* do not implement the solution
* do not add extra abstractions
* do not change repository structure
* do not add packages
* do not refactor unrelated files
* do not move files to mark an implementation as preferred

If the exact official C# public API is unknown, ask for the signature or problem statement instead of guessing.
