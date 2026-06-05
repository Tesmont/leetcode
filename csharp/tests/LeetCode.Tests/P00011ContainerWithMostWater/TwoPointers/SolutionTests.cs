using LeetCode.P00011ContainerWithMostWater.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00011ContainerWithMostWater.SolutionTestCases;

namespace LeetCode.Tests.P00011ContainerWithMostWater.TwoPointers;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MaxAreaCases), MemberType = typeof(RootSolutionTestCases))]
    public void MaxArea_ReturnsMaximumContainedWater(int[] height, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxArea(height);

        Assert.Equal(expected, actual);
    }
}
