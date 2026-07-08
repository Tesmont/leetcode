using LeetCode.P01046LastStoneWeight.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01046LastStoneWeight.SolutionTestCases;

namespace LeetCode.Tests.P01046LastStoneWeight.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.LastStoneWeightCases), MemberType = typeof(RootSolutionTestCases))]
    public void LastStoneWeight_ReturnsRemainingStoneWeight(int[] stones, int expected)
    {
        Solution solution = new();

        int actual = solution.LastStoneWeight(stones);

        Assert.Equal(expected, actual);
    }
}
