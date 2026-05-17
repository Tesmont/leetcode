using LeetCode.P02958LengthOfLongestSubarrayWithAtMostKFrequency;
using Xunit;

namespace LeetCode.Tests.P02958LengthOfLongestSubarrayWithAtMostKFrequency;

public sealed class SolutionTests
{
    public static TheoryData<int[], int, int> MaxSubarrayLengthCases =>
        new()
        {
            { [1, 2, 3, 1, 2, 3, 1, 2], 2, 6 },
            { [1, 2, 1, 2, 1, 2, 1, 2], 1, 2 },
            { [5, 5, 5, 5, 5, 5, 5], 4, 4 },
            { [1], 1, 1 },
        };

    [Theory]
    [MemberData(nameof(MaxSubarrayLengthCases))]
    public void MaxSubarrayLength_ReturnsLongestGoodSubarrayLength(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxSubarrayLength(nums, k);

        Assert.Equal(expected, actual);
    }
}
