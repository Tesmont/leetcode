using LeetCode.P01496PathCrossing;
using Xunit;

namespace LeetCode.Tests.P01496PathCrossing;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.IsPathCrossingCases), MemberType = typeof(SolutionTestCases))]
    public void IsPathCrossing_ReturnsWhetherPathCrossesItself(string path, bool expected)
    {
        Solution solution = new();

        bool actual = solution.IsPathCrossing(path);

        Assert.Equal(expected, actual);
    }
}
