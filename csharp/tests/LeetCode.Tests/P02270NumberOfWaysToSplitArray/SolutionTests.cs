using LeetCode.P02270NumberOfWaysToSplitArray;
using Xunit;

namespace LeetCode.Tests.P02270NumberOfWaysToSplitArray;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.WaysToSplitArrayCases), MemberType = typeof(SolutionTestCases))]
    public void WaysToSplitArray_ReturnsExpectedCount(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.WaysToSplitArray(nums);

        Assert.Equal(expected, actual);
    }
}
