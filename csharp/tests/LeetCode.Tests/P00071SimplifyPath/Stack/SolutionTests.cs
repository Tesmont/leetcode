using LeetCode.P00071SimplifyPath.Stack;
using Xunit;

namespace LeetCode.Tests.P00071SimplifyPath.Stack;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(
        nameof(P00071SimplifyPath.SolutionTestCases.SimplifyPathCases),
        MemberType = typeof(P00071SimplifyPath.SolutionTestCases))]
    public void SimplifyPath_ReturnsCanonicalPath(string path, string expected)
    {
        Solution solution = new();

        string actual = solution.SimplifyPath(path);

        Assert.Equal(expected, actual);
    }
}
