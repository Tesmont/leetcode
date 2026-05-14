using LeetCode.P01496PathCrossing;
using Xunit;

namespace LeetCode.Tests.P01496PathCrossing;

public sealed class SolutionTests
{
    public static TheoryData<string, bool> IsPathCrossingCases =>
        new()
        {
            { "NES", false },
            { "NESWW", true },
        };

    [Theory]
    [MemberData(nameof(IsPathCrossingCases))]
    public void IsPathCrossing_ReturnsWhetherPathCrossesItself(string path, bool expected)
    {
        Solution solution = new();

        bool actual = solution.IsPathCrossing(path);

        Assert.Equal(expected, actual);
    }
}
