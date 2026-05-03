using LeetCode.P00209MinimumSizeSubarraySum;
using Xunit;

namespace LeetCode.Tests.P00209MinimumSizeSubarraySum;

public sealed class SolutionTests
{
    public static TheoryData<int, int[], int> MinSubArrayLenCases =>
        new()
        {
            { 7, [2, 3, 1, 2, 4, 3], 2 },
            { 4, [1, 4, 4], 1 },
            { 11, [1, 1, 1, 1, 1, 1, 1, 1], 0 },
        };

    [Theory]
    [MemberData(nameof(MinSubArrayLenCases))]
    public void MinSubArrayLen_ReturnsExpectedLength(int target, int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MinSubArrayLen(target, nums);

        Assert.Equal(expected, actual);
    }
}
