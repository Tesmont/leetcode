using LeetCode.P00713SubarrayProductLessThanK;
using Xunit;

namespace LeetCode.Tests.P00713SubarrayProductLessThanK;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.NumSubarrayProductLessThanKCases), MemberType = typeof(SolutionTestCases))]
    public void NumSubarrayProductLessThanK_ReturnsExpectedCount(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.NumSubarrayProductLessThanK(nums, k);

        Assert.Equal(expected, actual);
    }
}
