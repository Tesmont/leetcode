# Structure Rules

## Core Structure Decision

Every solution implementation must live in its own approach directory.

The problem root directory must not contain `Solution.cs`.

All implementations are structurally equal.

This avoids moving code between the problem root and approach folders when a better solution is added later.

## Repository Structure

```text
csharp/
  LeetCode.slnx
  src/
    LeetCode/
      P00002AddTwoNumbers/
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
* tests mirror implementation approach directories for `SolutionTests.cs`
* each problem has exactly one `SolutionTestCases.cs` in the root test directory
* implementation test subdirectories must contain `SolutionTests.cs` only unless explicitly requested otherwise

## Implementation Approach Rules

When creating an implementation approach, the AI must:

* create a new approach subdirectory inside the problem directory
* use the approach name as the subdirectory name
* create `Solution.cs` inside that subdirectory
* create the official LeetCode public class, such as `Solution` or the design class name
* create every method or constructor with the correct public signature
* use the namespace that mirrors the problem directory and approach directory
* add the XML summary block to the primary LeetCode class
* keep the solution self-contained
* not modify other implementations unless explicitly requested

When adding a new implementation approach to an existing problem, the AI must:

* create only the new implementation approach directory
* create only the new implementation `Solution.cs`
* create only the matching test approach directory
* create only the matching `SolutionTests.cs`
* reuse the existing root `SolutionTestCases.cs`
* not move existing implementations
* not rename existing implementations
* not modify existing implementations unless explicitly requested

## Solution File Rules

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

XML summary comments are allowed only for the primary LeetCode class.

Do not add XML documentation to:

* methods
* test classes
* helper types
* fields
* test cases

unless explicitly requested.

## Summary Rules

For each primary LeetCode class added:

* add an XML summary block to the primary LeetCode class
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
