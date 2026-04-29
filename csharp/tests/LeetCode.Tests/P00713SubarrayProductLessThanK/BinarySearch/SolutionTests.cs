using LeetCode.P00713SubarrayProductLessThanK.BinarySearch;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00713SubarrayProductLessThanK.SolutionTestCases;

namespace LeetCode.Tests.P00713SubarrayProductLessThanK.BinarySearch;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.NumSubarrayProductLessThanKCases), MemberType = typeof(RootSolutionTestCases))]
    public void NumSubarrayProductLessThanK_ReturnsExpectedCount(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.NumSubarrayProductLessThanK(nums, k);

        Assert.Equal(expected, actual);
    }
}
