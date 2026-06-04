using LeetCode.P02958LengthOfLongestSubarrayWithAtMostKFrequency.SlidingWindow;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02958LengthOfLongestSubarrayWithAtMostKFrequency.SolutionTestCases;

namespace LeetCode.Tests.P02958LengthOfLongestSubarrayWithAtMostKFrequency.SlidingWindow;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MaxSubarrayLengthCases), MemberType = typeof(RootSolutionTestCases))]
    public void MaxSubarrayLength_ReturnsLongestGoodSubarrayLength(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxSubarrayLength(nums, k);

        Assert.Equal(expected, actual);
    }
}
