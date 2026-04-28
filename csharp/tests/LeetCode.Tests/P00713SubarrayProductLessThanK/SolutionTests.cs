using LeetCode.P00713SubarrayProductLessThanK;
using Xunit;

namespace LeetCode.Tests.P00713SubarrayProductLessThanK;

public sealed class SolutionTests
{
    public static TheoryData<int[], int, int> NumSubarrayProductLessThanKCases =>
        new()
        {
            { [10, 5, 2, 6], 100, 8 },
            { [1, 2, 3], 0, 0 },
        };

    [Theory]
    [MemberData(nameof(NumSubarrayProductLessThanKCases))]
    public void NumSubarrayProductLessThanK_ReturnsExpectedCount(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.NumSubarrayProductLessThanK(nums, k);

        Assert.Equal(expected, actual);
    }
}
