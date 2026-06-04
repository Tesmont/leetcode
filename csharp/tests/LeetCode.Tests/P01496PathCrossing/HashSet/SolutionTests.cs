using LeetCode.P01496PathCrossing.HashSet;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01496PathCrossing.SolutionTestCases;

namespace LeetCode.Tests.P01496PathCrossing.HashSet;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.IsPathCrossingCases), MemberType = typeof(RootSolutionTestCases))]
    public void IsPathCrossing_ReturnsWhetherPathCrossesItself(string path, bool expected)
    {
        Solution solution = new();

        bool actual = solution.IsPathCrossing(path);

        Assert.Equal(expected, actual);
    }
}
