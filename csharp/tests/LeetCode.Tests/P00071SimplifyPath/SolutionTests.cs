using LeetCode.P00071SimplifyPath;
using Xunit;

namespace LeetCode.Tests.P00071SimplifyPath;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.SimplifyPathCases), MemberType = typeof(SolutionTestCases))]
    public void SimplifyPath_ReturnsCanonicalPath(string path, string expected)
    {
        Solution solution = new();

        string actual = solution.SimplifyPath(path);

        Assert.Equal(expected, actual);
    }
}
