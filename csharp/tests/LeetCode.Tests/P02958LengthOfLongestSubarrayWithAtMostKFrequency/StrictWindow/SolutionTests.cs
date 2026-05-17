using LeetCode.P02958LengthOfLongestSubarrayWithAtMostKFrequency.StrictWindow;
using Xunit;
using RootSolutionTests = LeetCode.Tests.P02958LengthOfLongestSubarrayWithAtMostKFrequency.SolutionTests;

namespace LeetCode.Tests.P02958LengthOfLongestSubarrayWithAtMostKFrequency.StrictWindow;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTests.MaxSubarrayLengthCases), MemberType = typeof(RootSolutionTests))]
    public void MaxSubarrayLength_ReturnsLongestGoodSubarrayLength(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxSubarrayLength(nums, k);

        Assert.Equal(expected, actual);
    }
}
