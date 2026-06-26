# Workflows

## New Problem In Boilerplate Mode

When given a new problem in boilerplate mode:

* determine the problem number and official English name
* determine the official LeetCode C# public API
* determine the implementation approach name
* use `Initial` as the approach name if no approach is specified
* create the source problem directory
* create the source implementation approach directory
* create `Solution.cs` inside the implementation approach directory
* create the official LeetCode public class
* add the XML summary block to the primary LeetCode class
* create every method or constructor with the correct public signature
* add required public helper types in `Solution.cs` if the problem needs them
* keep every generated primary LeetCode public method or constructor body as `throw new System.NotImplementedException();`
* create the root test problem directory
* create `SolutionTestCases.cs`
* create the test implementation approach directory
* create `SolutionTests.cs` inside the test implementation approach directory
* add test cases based on problem examples to `SolutionTestCases.cs`
* add test methods that consume `SolutionTestCases.cs` to `SolutionTests.cs`

## New Implementation Approach In Boilerplate Mode

When given a new implementation approach in boilerplate mode:

* determine the approach name
* create the source implementation approach subdirectory
* create the implementation `Solution.cs`
* use the same public API signatures as the existing implementations
* keep every generated primary LeetCode public method or constructor body as `throw new System.NotImplementedException();`
* create the mirrored test implementation approach subdirectory
* create `SolutionTests.cs` in the test implementation approach subdirectory
* reuse the root problem `SolutionTestCases.cs`
* do not create another `SolutionTestCases.cs`
* do not move existing implementations
* do not modify existing implementations unless explicitly requested
