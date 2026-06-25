# Naming And Signature Rules

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
BFS
DFS
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

## Namespace Rules

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

## Signature Rules

Use the official LeetCode C# public API as the base API.

Most algorithm problems use a `Solution` class with one public method.

Design problems must use the official LeetCode design class name, constructor, and public methods instead of forcing a `Solution` class.

Examples of design class names:

```text
MinStack
MyQueue
MyStack
NumArray
MovingAverage
RecentCounter
StockSpanner
MyLinkedList
```

Rules:

* use `Solution` only when the official C# API uses `Solution`
* use the official design class name when the problem defines one
* keep constructor and method signatures compatible with the official C# API
* tests must instantiate the official public class for the approach being tested
* do not wrap design classes in an extra `Solution` class
* do not rename official design methods for style

The signature may be adjusted with nullable reference type annotations when `null` is part of the valid input or output domain according to the problem statement.

Do not guess the public API signature.

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

If the exact C# public API cannot be determined from the provided link, problem statement, existing code, or user message, ask for the exact signature or problem statement.

## Nullability Rules

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
