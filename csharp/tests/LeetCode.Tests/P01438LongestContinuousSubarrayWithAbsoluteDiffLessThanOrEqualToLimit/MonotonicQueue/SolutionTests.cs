using LeetCode.P01438LongestContinuousSubarrayWithAbsoluteDiffLessThanOrEqualToLimit.MonotonicQueue;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01438LongestContinuousSubarrayWithAbsoluteDiffLessThanOrEqualToLimit.SolutionTestCases;

namespace LeetCode.Tests.P01438LongestContinuousSubarrayWithAbsoluteDiffLessThanOrEqualToLimit.MonotonicQueue;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.LongestSubarrayCases), MemberType = typeof(RootSolutionTestCases))]
    public void LongestSubarray_ReturnsLongestValidWindowLength(int[] nums, int limit, int expected)
    {
        Solution solution = new();

        int actual = solution.LongestSubarray(nums, limit);

        Assert.Equal(expected, actual);
    }
}
