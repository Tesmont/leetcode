using LeetCode.P00071SimplifyPath.SpanStack;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00071SimplifyPath.SolutionTestCases;

namespace LeetCode.Tests.P00071SimplifyPath.SpanStack;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.SimplifyPathCases), MemberType = typeof(RootSolutionTestCases))]
    public void SimplifyPath_ReturnsCanonicalPath(string path, string expected)
    {
        Solution solution = new();

        string actual = solution.SimplifyPath(path);

        Assert.Equal(expected, actual);
    }
}
