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
- implement solution logic when asked to create boilerplate
- add partial implementations, TODO algorithms, helper methods, loops, conditionals, or placeholder returns to boilerplate solutions
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
- DO NOT implement any solution logic
- DO NOT add partial implementations
- DO NOT add loops, conditionals, helper methods, private methods, local functions, comments describing algorithm steps, TODO algorithm bodies, or placeholder return values
- the method body must contain only `throw new System.NotImplementedException();`

When creating an alternative implementation:

- create a new subdirectory next to the main `Solution.cs`
- create `Solution.cs` inside that subdirectory
- use the alternative approach name as the subdirectory name
- create class `Solution`
- create the method with the same public signature as the main solution
- DO NOT implement any solution logic
- the method body must contain only `throw new System.NotImplementedException();`
- do not modify the main implementation unless explicitly requested

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

When a problem has more than one implementation approach:

- rewrite duplicated inline test cases into a shared test helper
- keep the shared helper under the same problem test directory
- create one test class for the main approach
- create one test class in a mirrored subdirectory for each alternative approach
- each approach test class must use the same shared test cases
- each approach test class must instantiate only its own `Solution` class
- do not use interfaces, dependency injection, reflection, or abstract test frameworks unless explicitly requested

Example:

tests/
  LeetCode.Tests/
    P00002AddTwoNumbers/
      SolutionTestCases.cs
      SolutionTests.cs
      Recursive/
        SolutionTests.cs
      Stack/
        SolutionTests.cs

Expected state:
- every newly created boilerplate `Solution` method throws `System.NotImplementedException`
- tests already exist and call the method
- tests may fail until the corresponding solution approach is implemented

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

## Summary rules

For each solution added:
- add an XML summary block in Solution.cs
- include the LeetCode problem link in the summary block
- include the full problem number and name in the summary block

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
