# Test Rules

## Test Rules

Tests must be real and runnable.

Tests must:

* call the solution method
* use examples from the problem statement
* keep test cases in `SolutionTestCases.cs`
* keep test methods in approach-specific `SolutionTests.cs`
* create exactly one `SolutionTestCases.cs` per problem
* share the root problem `SolutionTestCases.cs` across all implementations
* instantiate only the official public class for the approach being tested
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

## Shared Test Case Rules

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

## Test Helper Rules

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

## Test Framework Rules

Use the existing test framework and assertion style already used in `LeetCode.Tests`.

Do not add a different test framework.

Do not add new assertion libraries.

Do not add new test packages.

Do not modify `.csproj`, `.sln`, or `.slnx` files for tests unless explicitly requested or required for compilation.
