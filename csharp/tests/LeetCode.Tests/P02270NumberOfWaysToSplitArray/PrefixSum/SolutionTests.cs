using LeetCode.P02270NumberOfWaysToSplitArray.PrefixSum;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02270NumberOfWaysToSplitArray.SolutionTestCases;

namespace LeetCode.Tests.P02270NumberOfWaysToSplitArray.PrefixSum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.WaysToSplitArrayCases), MemberType = typeof(RootSolutionTestCases))]
    public void WaysToSplitArray_ReturnsExpectedCount(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.WaysToSplitArray(nums);

        Assert.Equal(expected, actual);
    }
}
