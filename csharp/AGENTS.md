# AGENTS.md

## Purpose

This repository stores personal LeetCode solutions in C#.

The AI is allowed to:

* take a LeetCode problem link or problem statement
* create boilerplate code
* create real tests based on the problem examples
* create multiple implementation approaches for the same problem
* implement solution logic only when explicitly requested

The AI must not redesign the repository or introduce architecture.

## Core structure decision

Every solution implementation must live in its own approach directory.

The problem root directory must not contain `Solution.cs`.

All implementations are structurally equal. The preferred or best implementation is marked in the problem `README.md`, not by moving files.

This avoids moving code between the problem root and approach folders when a better solution is added later.

## Modes

### Boilerplate mode

Boilerplate mode is the default when the user asks to create, add, scaffold, prepare, or set up a new problem or implementation approach.

In boilerplate mode, the AI must:

* create the required directories and files
* create the correct public method signature
* add required LeetCode helper types if needed
* create real runnable tests based on the problem examples
* keep every new `Solution` method unimplemented
* use only `throw new System.NotImplementedException();` inside every new `Solution` method body

In boilerplate mode, the AI must not:

* implement solution logic
* add partial implementations
* add TODO algorithms
* add placeholder return values
* make tests pass by implementing the solution

Generated tests are expected to fail with `System.NotImplementedException` until the user explicitly asks to implement the solution.

Generated code should compile. Generated behavior tests may fail in boilerplate mode.

### Implementation mode

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

## Allowed actions

The AI may:

* create a problem directory
* create an implementation approach directory
* create `Solution.cs` inside an implementation approach directory
* create `README.md` in the problem root directory
* create `SolutionTestCases.cs`
* create `SolutionTests.cs`
* copy examples from the problem statement into tests
* add simple edge cases when they improve confidence or coverage
* add small helper methods in tests when needed
* keep solution files self-contained for easy LeetCode submission
* create additional implementation approach directories when explicitly requested

## Forbidden actions

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
* modify `.sln` or `.csproj` files unless explicitly requested or required for compilation
* create `Best`, `Preferred`, `Optimal`, or `Main` implementation directories unless explicitly requested

Assume SDK-style project file globbing includes new `.cs` files.

## Repository structure

```text
csharp/
  LeetCode.sln
  src/
    LeetCode/
      P00002AddTwoNumbers/
        README.md
        Initial/
          Solution.cs
        Recursive/
          Solution.cs
        Stack/
          Solution.cs
  tests/
    LeetCode.Tests/
      P00002AddTwoNumbers/
        SolutionTestCases.cs
        Initial/
          SolutionTests.cs
        Recursive/
          SolutionTests.cs
        Stack/
          SolutionTests.cs
```

Rules:

* one problem equals one directory
* the problem root directory must not contain `Solution.cs`
* every implementation lives in its own approach subdirectory
* the problem root may contain `README.md`
* tests mirror implementation approach directories for `SolutionTests.cs`
* each problem has exactly one `SolutionTestCases.cs` in the root test directory
* implementation test subdirectories must contain `SolutionTests.cs` only unless explicitly requested otherwise

## Preferred implementation rules

Preferred implementation must not be represented by moving files.

To mark the best, recommended, or currently preferred implementation, update the problem `README.md`.

The preferred implementation is informational only.

Example:

```md
## Preferred implementation

TwoPointers
```

Do not:

* move implementation files just to mark a different approach as preferred
* duplicate one implementation into another directory just to mark it as preferred
* create `Best`, `Preferred`, `Optimal`, or `Main` directories unless explicitly requested
* use physical location as a ranking mechanism

## Problem README rules

Each problem directory should contain a `README.md`.

The `README.md` should be minimal and factual.

Example:

```md
# LeetCode 11. Container With Most Water

https://leetcode.com/problems/container-with-most-water/

## Preferred implementation

TwoPointers

## Implementations

| Implementation | Time | Space | Status |
|---|---:|---:|---|
| BruteForce | O(n²) | O(1) | Reference |
| TwoPointers | O(n) | O(1) | Preferred |
```

Rules:

* use the official LeetCode problem number and name
* include the LeetCode problem link
* list known implementations
* mark the preferred implementation when known
* use `Unknown` for time or space complexity if not known yet
* do not write long explanations unless explicitly requested
* do not turn the README into a tutorial unless explicitly requested

## Naming

Problem directories use this format:

```text
P00001TwoSum
P00002AddTwoNumbers
P00392IsSubsequence
```

Rules:

* use the official LeetCode problem number
* use five-digit zero padding
* convert the official English problem title to PascalCase
* remove spaces, hyphens, apostrophes, colons, and punctuation
* do not invent shorter names

Examples:

```text
1. Two Sum
P00001TwoSum

2. Add Two Numbers
P00002AddTwoNumbers

3. Longest Substring Without Repeating Characters
P00003LongestSubstringWithoutRepeatingCharacters

151. Reverse Words in a String
P00151ReverseWordsInAString

392. Is Subsequence
P00392IsSubsequence
```

Files:

```text
README.md
Solution.cs
SolutionTests.cs
SolutionTestCases.cs
```

Implementation approach directory names must be clear PascalCase approach names.

Preferred examples:

```text
Initial
Recursive
Stack
MonotonicStack
DynamicProgramming
BinarySearch
TwoPointers
SlidingWindow
PrefixSum
Greedy
BruteForce
Jumping
HashMap
HashSet
Sorting
Counting
Backtracking
BreadthFirstSearch
DepthFirstSearch
UnionFind
```

Use `Initial` when the approach is not known yet or the user only asks to create a new problem without naming an approach.

Avoid vague names:

```text
Temp
New
Try2
Better
Final
Optimized2
Solution1
Solution2
```

## Namespace rules

Namespaces must mirror the problem directory and implementation approach directory.

Solution example:

```csharp
namespace LeetCode.P00392IsSubsequence.TwoPointers;
```

Test example:

```csharp
namespace LeetCode.Tests.P00392IsSubsequence.TwoPointers;
```

Shared test case namespace example:

```csharp
namespace LeetCode.Tests.P00392IsSubsequence;
```

Rules:

* implementation namespaces include the approach directory
* implementation test namespaces include the approach directory
* `SolutionTestCases.cs` stays in the root problem test namespace
* there is no root implementation namespace containing a `Solution` class

## Signature rules

Use the official LeetCode C# method signature as the base signature.

The signature may be adjusted with nullable reference type annotations when `null` is part of the valid input or output domain according to the problem statement.

Do not guess the method signature.

Do not translate signatures from Java, Python, C++, or other languages.

Do not replace official LeetCode collection types with preferred alternatives.

Do not replace:

```text
int[]
```

with:

```text
IReadOnlyList<int>
List<int>
IEnumerable<int>
```

Do not replace:

```text
IList<IList<int>>
```

with:

```text
List<List<int>>
int[][]
```

unless the official C# signature uses those types or the user explicitly requests the change.

If the exact C# signature cannot be determined from the provided link, problem statement, existing code, or user message, ask for the exact signature or problem statement.

## Nullability rules

Use nullable reference type annotations when they reflect the valid input or output domain of the LeetCode problem.

LeetCode C# signatures often omit nullable annotations for reference types even when `null` is a valid input or output value.

Because LeetCode accepts nullable reference type annotations in submitted C# code, this repository may use nullable annotations when they make the contract more accurate.

Examples:

```csharp
public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
```

```csharp
public TreeNode? InvertTree(TreeNode? root)
```

```csharp
public string? SomeMethod(string? value)
```

```csharp
public int[]? SomeMethod(int[]? nums)
```

Rules:

* add `?` when `null` is part of the valid input domain
* add `?` when `null` is part of the valid output domain
* do not add `?` when the problem statement guarantees the value is non-null
* do not add defensive null handling for inputs that the problem statement guarantees are non-null
* include focused null test cases when `null` is part of the valid input domain
* keep helper type fields nullable when they can naturally be absent, such as `next`, `left`, or `right`

Examples of helper types:

```csharp
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

```csharp
public sealed class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
```

Prefer accurate nullability over blindly copying LeetCode's nullable-annotation omissions.

Do not change collection shapes only for style.

For example, do not replace:

```csharp
public IList<IList<int>> ThreeSum(int[] nums)
```

with:

```csharp
public List<List<int>> ThreeSum(int[] nums)
```

unless explicitly requested or required by the existing repository style.

## Boilerplate rules

When creating a new implementation, the AI must:

* create class `Solution`
* create the method with the correct public signature
* not implement any solution logic
* not add partial implementations
* not add loops
* not add conditionals
* not add helper methods
* not add private methods
* not add local functions
* not add comments describing algorithm steps
* not add TODO algorithm bodies
* not add placeholder return values

The method body must contain only:

```csharp
throw new System.NotImplementedException();
```

Example:

```csharp
namespace LeetCode.P00001TwoSum.Initial;

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

## Implementation approach rules

When creating an implementation approach, the AI must:

* create a new approach subdirectory inside the problem directory
* use the approach name as the subdirectory name
* create `Solution.cs` inside that subdirectory
* create class `Solution`
* create the method with the correct public signature
* use the namespace that mirrors the problem directory and approach directory
* add the XML summary block to the `Solution` class
* keep the solution self-contained
* not modify other implementations unless explicitly requested

In boilerplate mode, the method body must contain only:

```csharp
throw new System.NotImplementedException();
```

When adding a new implementation approach to an existing problem, the AI must:

* create only the new implementation approach directory
* create only the new implementation `Solution.cs`
* create only the matching test approach directory
* create only the matching `SolutionTests.cs`
* reuse the existing root `SolutionTestCases.cs`
* update the problem `README.md`
* not move existing implementations
* not rename existing implementations
* not modify existing implementations unless explicitly requested

## Solution file rules

Solution files must be self-contained.

If the problem requires helper types such as `ListNode`, `TreeNode`, `Node`, or other custom argument or return types:

* define those helper types in the same `Solution.cs` file
* define helper types near the `Solution` class
* make helper types public
* keep helper type names and shapes compatible with LeetCode
* do not split required helper types across files
* repeat helper types in each implementation's `Solution.cs` when needed for LeetCode copy-paste compatibility

Example:

```csharp
namespace LeetCode.P00002AddTwoNumbers.Initial;

/// <summary>
/// LeetCode 2. Add Two Numbers.
/// https://leetcode.com/problems/add-two-numbers/
/// </summary>
public sealed class Solution
{
    public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
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

XML summary comments are allowed only for the `Solution` class.

Do not add XML documentation to:

* methods
* test classes
* helper types
* fields
* test cases

unless explicitly requested.

## Test rules

Tests must be real and runnable.

Tests must:

* call the solution method
* use examples from the problem statement
* keep test cases in `SolutionTestCases.cs`
* keep test methods in approach-specific `SolutionTests.cs`
* create exactly one `SolutionTestCases.cs` per problem
* share the root problem `SolutionTestCases.cs` across all implementations
* instantiate only the `Solution` class for the approach being tested
* compile successfully

Tests may:

* include simple edge cases
* include additional test cases when they improve confidence or coverage
* use small helper methods to build inputs, convert outputs, compare helper types, or normalize valid output shapes

Tests must not:

* be empty
* be commented out
* implement the solution algorithm
* duplicate the solution algorithm
* make tests pass by changing solution boilerplate
* create `SolutionTestCases.cs` inside implementation approach test subdirectories
* use interfaces
* use dependency injection
* use reflection
* use abstract test frameworks
* add packages

It is expected that tests fail with `System.NotImplementedException` for newly generated boilerplate.

Every root problem test directory must contain:

```text
SolutionTestCases.cs
```

Every implementation approach test directory must contain:

```text
SolutionTests.cs
```

Example:

```text
tests/
  LeetCode.Tests/
    P00002AddTwoNumbers/
      SolutionTestCases.cs
      Initial/
        SolutionTests.cs
      Recursive/
        SolutionTests.cs
      Stack/
        SolutionTests.cs
```

Expected state in boilerplate mode:

* every newly created `Solution` method throws `System.NotImplementedException`
* tests already exist
* tests call the method
* tests may fail until the corresponding solution approach is implemented

## Shared test case rules

`SolutionTestCases.cs` must contain shared test data for the whole problem.

When a problem uses only primitive values, strings, arrays, or standard collections, shared test cases may use those types directly.

When a problem uses implementation-specific helper types such as `ListNode`, `TreeNode`, or `Node`, shared test cases must store neutral input and expected data instead of implementation-specific helper objects.

Preferred neutral test data examples:

```csharp
public static TheoryData<int[], int[], int[]> AddTwoNumbersCases => new()
{
    { [2, 4, 3], [5, 6, 4], [7, 0, 8] },
};
```

```csharp
public static TheoryData<int?[], int?[]> TreeCases => new()
{
    { [4, 2, 7, 1, 3, 6, 9], [4, 7, 2, 9, 6, 3, 1] },
};
```

Approach-specific `SolutionTests.cs` files may convert neutral test data into the helper types defined by that approach's `Solution.cs`.

This keeps each `Solution.cs` self-contained and still allows all implementations to share the same test cases.

## Test helper rules

Small test helper methods are allowed when they only build inputs, convert outputs, compare helper types, or normalize valid output shapes.

Allowed examples:

* build a `ListNode` from an array
* convert a `ListNode` to an array
* build a `TreeNode` from level-order data
* compare trees
* compare linked lists
* sort outputs when the problem allows any order
* compare unordered outputs when the problem allows any order

Test helpers must not:

* implement the solution algorithm
* duplicate the solution algorithm
* hide important assertions
* make invalid outputs look valid

When a problem allows multiple valid outputs, tests must assert according to the problem rules instead of requiring one arbitrary output order.

## Test framework rules

Use the existing test framework and assertion style already used in `LeetCode.Tests`.

Do not add a different test framework.

Do not add new assertion libraries.

Do not add new test packages.

Do not modify `.csproj` or `.sln` files for tests unless explicitly requested or required for compilation.

## Code style

Follow `.editorconfig`.

Do not define formatting or style rules in this document.

Use explicit types if that is already required by the repository style.

Do not introduce unrelated style changes.

## Workflow

When given a new problem in boilerplate mode:

* determine the problem number and official English name
* determine the official LeetCode C# method signature
* determine the implementation approach name
* use `Initial` as the approach name if no approach is specified
* create the source problem directory
* create the problem `README.md`
* create the source implementation approach directory
* create `Solution.cs` inside the implementation approach directory
* create class `Solution`
* add the XML summary block to the `Solution` class
* create the method with the correct public signature
* add required public helper types in `Solution.cs` if the problem needs them
* keep the method body as `throw new System.NotImplementedException();`
* create the root test problem directory
* create `SolutionTestCases.cs`
* create the test implementation approach directory
* create `SolutionTests.cs` inside the test implementation approach directory
* add test cases based on problem examples to `SolutionTestCases.cs`
* add test methods that consume `SolutionTestCases.cs` to `SolutionTests.cs`
* update `README.md` with the implementation approach

When given a new implementation approach in boilerplate mode:

* determine the approach name
* create the source implementation approach subdirectory
* create the implementation `Solution.cs`
* use the same public method signature as the existing implementations
* keep the method body as `throw new System.NotImplementedException();`
* create the mirrored test implementation approach subdirectory
* create `SolutionTests.cs` in the test implementation approach subdirectory
* reuse the root problem `SolutionTestCases.cs`
* do not create another `SolutionTestCases.cs`
* update the problem `README.md`
* do not move existing implementations
* do not modify existing implementations unless explicitly requested

When given an implementation request:

* modify only the requested implementation
* keep the solution self-contained
* keep helper methods inside the same `Solution.cs` file
* keep tests shared when possible
* update approach-specific tests only when needed
* update the problem `README.md` if complexity or preferred status changes
* do not refactor unrelated approaches
* do not change repository structure unless explicitly requested

When the user says a solution is better, preferred, main, recommended, or optimal:

* update the problem `README.md`
* mark that approach as preferred
* do not move files
* do not rename directories
* do not duplicate implementations

## Summary rules

For each `Solution` class added:

* add an XML summary block to the `Solution` class
* include the full LeetCode problem number and name
* include the LeetCode problem link
* use the same summary for all implementations of the same problem

Example:

```csharp
/// <summary>
/// LeetCode 392. Is Subsequence.
/// https://leetcode.com/problems/is-subsequence/
/// </summary>
```

## Priority

When rules conflict, use this priority order:

* correctness of structure
* official LeetCode C# signature compatibility
* runnable tests
* self-contained LeetCode copy-paste solutions
* stable implementation directories
* minimal boilerplate
* readability

## Default behavior

If unsure:

* generate minimal boilerplate
* use `Initial` as the first implementation approach name
* do not implement the solution
* do not add extra abstractions
* do not change repository structure
* do not add packages
* do not refactor unrelated files
* do not move files to mark an implementation as preferred

If the exact official C# signature is unknown, ask for the signature or problem statement instead of guessing.
