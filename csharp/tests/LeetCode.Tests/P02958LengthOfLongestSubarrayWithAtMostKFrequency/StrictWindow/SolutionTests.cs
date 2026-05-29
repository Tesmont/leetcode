using LeetCode.P02958LengthOfLongestSubarrayWithAtMostKFrequency.StrictWindow;
using Xunit;

namespace LeetCode.Tests.P02958LengthOfLongestSubarrayWithAtMostKFrequency.StrictWindow;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.MaxSubarrayLengthCases), MemberType = typeof(SolutionTestCases))]
    public void MaxSubarrayLength_ReturnsLongestGoodSubarrayLength(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxSubarrayLength(nums, k);

        Assert.Equal(expected, actual);
    }
}
