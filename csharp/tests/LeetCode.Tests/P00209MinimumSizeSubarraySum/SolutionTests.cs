using LeetCode.P00209MinimumSizeSubarraySum;
using Xunit;

namespace LeetCode.Tests.P00209MinimumSizeSubarraySum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.MinSubArrayLenCases), MemberType = typeof(SolutionTestCases))]
    public void MinSubArrayLen_ReturnsExpectedLength(int target, int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MinSubArrayLen(target, nums);

        Assert.Equal(expected, actual);
    }
}
