using LeetCode.P02101DetonateTheMaximumBombs.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02101DetonateTheMaximumBombs.SolutionTestCases;

namespace LeetCode.Tests.P02101DetonateTheMaximumBombs.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MaximumDetonationCases), MemberType = typeof(RootSolutionTestCases))]
    public void MaximumDetonation_ReturnsMaximumNumberOfBombs(int[][] bombs, int expected)
    {
        Solution solution = new();

        int actual = solution.MaximumDetonation(bombs);

        Assert.Equal(expected, actual);
    }
}
