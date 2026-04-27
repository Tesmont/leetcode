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
- make tests pass by implementing solution logic unless explicitly requested

## Repository structure

```text
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
        SolutionTestCases.cs
        SolutionTests.cs
        Recursive/
          SolutionTests.cs
        Stack/
          SolutionTests.cs
```

Rules:
- one problem = one directory
- main implementation in root Solution.cs
- alternatives in subdirectories
- tests mirror source structure

## Naming

Problem directories:
- P00001TwoSum
- P00002AddTwoNumbers
- P00392IsSubsequence

Files:
- Solution.cs
- SolutionTests.cs
- SolutionTestCases.cs

Alternative implementations:
- Recursive
- Stack
- DynamicProgramming
- BinarySearch
- TwoPointers

Avoid:
- Temp
- New
- Try2

## Namespace rules

Namespaces must mirror the problem directory and alternative implementation directory.

Main solution example:

```csharp
namespace LeetCode.P00392IsSubsequence;
```

Alternative solution example:

```csharp
namespace LeetCode.P00392IsSubsequence.BinarySearch;
```

Main test example:

```csharp
namespace LeetCode.Tests.P00392IsSubsequence;
```

Alternative test example:

```csharp
namespace LeetCode.Tests.P00392IsSubsequence.BinarySearch;
```

## Boilerplate rules

When creating a new problem:

- create class Solution
- create method with correct public signature
- do not implement any solution logic
- do not add partial implementations
- do not add loops
- do not add conditionals
- do not add helper methods
- do not add private methods
- do not add local functions
- do not add comments describing algorithm steps
- do not add TODO algorithm bodies
- do not add placeholder return values
- the method body must contain only `throw new System.NotImplementedException();`

When creating an alternative implementation:

- create a new subdirectory next to the main Solution.cs
- create Solution.cs inside that subdirectory
- use the alternative approach name as the subdirectory name
- create class Solution
- create the method with the same public signature as the main solution
- do not implement any solution logic
- the method body must contain only `throw new System.NotImplementedException();`
- do not modify the main implementation unless explicitly requested

Example:

```csharp
namespace LeetCode.P00001TwoSum;

/// <summary>
/// LeetCode 1. Two Sum.
/// https://leetcode.com/problems/two-sum/
/// </summary>
public sealed class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        throw new System.NotImplementedException();
    }
}
```

## Solution file rules

Solution must be self-contained.

If the problem requires helper types such as `ListNode`, `TreeNode`, `Node`, or other custom argument or return types:

- define those helper types in the same Solution.cs file
- define helper types near the Solution class
- make helper types public
- keep helper type names and shapes compatible with LeetCode
- do not split required helper types across files

Example:

```csharp
namespace LeetCode.P00002AddTwoNumbers;

/// <summary>
/// LeetCode 2. Add Two Numbers.
/// https://leetcode.com/problems/add-two-numbers/
/// </summary>
public sealed class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        throw new System.NotImplementedException();
    }
}

public sealed class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}
```

Do not add comments inside method bodies.

XML summary comments are allowed only for the Solution class.

## Test rules

Tests must be real and runnable.

Tests:
- must call the solution method
- must use examples from the problem statement
- may include simple edge cases
- must not be empty or commented
- must not implement or duplicate the solution algorithm
- must not make tests pass by changing solution boilerplate

It is expected that tests fail with `System.NotImplementedException` for newly generated boilerplate.

When a problem has more than one implementation approach:

- rewrite duplicated inline test cases into a shared test helper
- keep the shared helper under the same problem test directory
- create one test class for the main approach
- create one test class in a mirrored subdirectory for each alternative approach
- each approach test class must use the same shared test cases
- each approach test class must instantiate only its own Solution class
- do not use interfaces, dependency injection, reflection, or abstract test frameworks unless explicitly requested

Example:

```text
tests/
  LeetCode.Tests/
    P00002AddTwoNumbers/
      SolutionTestCases.cs
      SolutionTests.cs
      Recursive/
        SolutionTests.cs
      Stack/
        SolutionTests.cs
```

Expected state:
- every newly created boilerplate Solution method throws `System.NotImplementedException`
- tests already exist and call the method
- tests may fail until the corresponding solution approach is implemented

## Code style

Follow .editorconfig.

Do not define style rules here.

## Workflow

When given a problem:

1. determine problem number and name
2. create directory
3. create Solution.cs
4. create method with correct signature
5. add required public helper types in Solution.cs if the problem needs them
6. throw NotImplementedException
7. create SolutionTests.cs
8. add tests based on problem examples

## Summary rules

For each solution added:

- add an XML summary block to the Solution class
- include the LeetCode problem link in the summary block
- include the full problem number and name in the summary block
- alternative implementations must also include the same summary

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