using LeetCode.P01004MaxConsecutiveOnesIII.SlidingWindowCount;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01004MaxConsecutiveOnesIII.SolutionTestCases;

namespace LeetCode.Tests.P01004MaxConsecutiveOnesIII.SlidingWindowCount;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.LongestOnesCases), MemberType = typeof(RootSolutionTestCases))]
    public void LongestOnes_ReturnsExpectedLength(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.LongestOnes(nums, k);

        Assert.Equal(expected, actual);
    }
}
