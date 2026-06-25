# Boilerplate Rules

## Boilerplate Mode

Boilerplate mode is the default when the user asks to create, add, scaffold, prepare, or set up a new problem or implementation approach.

In boilerplate mode, the AI must:

* create the required directories and files
* create the correct public API signature
* add required LeetCode helper types if needed
* create real runnable tests based on the problem examples
* keep every new public API member unimplemented
* use only `throw new System.NotImplementedException();` inside every new primary LeetCode public method or constructor body

In boilerplate mode, the AI must not:

* implement solution logic
* add partial implementations
* add TODO algorithms
* add placeholder return values
* make tests pass by implementing the solution

Generated tests are expected to fail with `System.NotImplementedException` until the user explicitly asks to implement the solution.

Generated code should compile. Generated behavior tests may fail in boilerplate mode.

## New Implementation Rules

When creating a new implementation, the AI must:

* create the official LeetCode public class, such as `Solution` or the design class name
* create every method or constructor with the correct public signature
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

Every generated primary LeetCode public method or constructor body must contain only:

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

When creating an implementation approach in boilerplate mode, every generated primary LeetCode public method or constructor body must contain only:

```csharp
throw new System.NotImplementedException();
```
