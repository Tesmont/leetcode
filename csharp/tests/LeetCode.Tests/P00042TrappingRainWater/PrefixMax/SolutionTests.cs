using LeetCode.P00042TrappingRainWater.PrefixMax;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00042TrappingRainWater.SolutionTestCases;

namespace LeetCode.Tests.P00042TrappingRainWater.PrefixMax;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.TrapCases), MemberType = typeof(RootSolutionTestCases))]
    public void Trap_ReturnsExpectedWaterAmount(int[] height, int expected)
    {
        Solution solution = new();

        int actual = solution.Trap(height);

        Assert.Equal(expected, actual);
    }
}
