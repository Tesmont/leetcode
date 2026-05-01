using LeetCode.P02270NumberOfWaysToSplitArray;
using Xunit;

namespace LeetCode.Tests.P02270NumberOfWaysToSplitArray;

public sealed class SolutionTests
{
    public static TheoryData<int[], int> WaysToSplitArrayCases =>
        new()
        {
            { [10, 4, -8, 7], 2 },
            { [2, 3, 1, 0], 2 },
        };

    [Theory]
    [MemberData(nameof(WaysToSplitArrayCases))]
    public void WaysToSplitArray_ReturnsExpectedCount(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.WaysToSplitArray(nums);

        Assert.Equal(expected, actual);
    }
}
