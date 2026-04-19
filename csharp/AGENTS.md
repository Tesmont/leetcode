# AGENTS.md

## Purpose

This repository stores personal LeetCode solutions in C#.

The AI is allowed to:
- take a LeetCode problem link or problem statement
- create boilerplate code
- create real tests based on the problem examples

The AI must not redesign the repository or introduce architecture.

## Allowed actions

The AI may:
- create a problem directory
- create Solution.cs
- create SolutionTests.cs
- copy examples from the problem statement into tests
- add small helper methods in tests if needed
- keep solution files self-contained for easy LeetCode submission

## Forbidden actions

The AI must not:
- add extra projects
- add dependency injection
- add logging
- add configuration files
- add service/repository layers
- add interfaces unless explicitly requested
- add NuGet packages unless explicitly requested
- rename existing files or directories
- refactor unrelated problems

## Repository structure

csharp/
  LeetCode.sln
  src/
    LeetCode/
      P00002AddTwoNumbers/
        Solution.cs
        Recursive/
          Solution.cs
        Stack/
          Solution.cs
  tests/
    LeetCode.Tests/
      P00002AddTwoNumbers/
        SolutionTests.cs
        Recursive/
          SolutionTests.cs
        Stack/
          SolutionTests.cs

Rules:
- one problem = one directory
- main implementation in root Solution.cs
- alternatives in subdirectories
- tests mirror source structure

## Boilerplate rules

When creating a new problem:

- create class Solution
- create method with correct signature
- DO NOT implement logic
- method must throw NotImplementedException

Example:

namespace LeetCode.P00001TwoSum;

public sealed class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        throw new System.NotImplementedException();
    }
}

## Test rules

Tests must be real and runnable.

Tests:
- must call the solution method
- must use examples from the problem statement
- may include simple edge cases
- must not be empty or commented

Expected state:
- Solution throws exception
- Tests already exist and call the method

## Solution file rules

Solution must be self-contained.

If problem requires helper types:
- keep them in the same Solution.cs file

Do not split required types across files.

## Naming

Problem directories:
- P00001TwoSum
- P00002AddTwoNumbers

Files:
- Solution.cs
- SolutionTests.cs

Alternative implementations:
- Recursive
- Stack
- DynamicProgramming

Avoid:
- Temp
- New
- Try2

## Code style

Follow .editorconfig.

Do not define style rules here.

## Workflow

When given a problem:

1. determine problem number and name
2. create directory
3. create Solution.cs
4. create method with correct signature
5. throw NotImplementedException
6. create SolutionTests.cs
7. add tests based on problem examples

## Priority

1. correctness of structure
2. runnable tests
3. minimal boilerplate
4. readability
5. easy LeetCode copy-paste

## Default behavior

If unsure:
- generate minimal boilerplate
- do not implement the solution
- do not add extra abstractions