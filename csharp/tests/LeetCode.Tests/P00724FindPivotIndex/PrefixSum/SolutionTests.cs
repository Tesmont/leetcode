using LeetCode.P00724FindPivotIndex.PrefixSum;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00724FindPivotIndex.SolutionTestCases;

namespace LeetCode.Tests.P00724FindPivotIndex.PrefixSum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.PivotIndexCases), MemberType = typeof(RootSolutionTestCases))]
    public void PivotIndex_ReturnsExpectedIndex(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.PivotIndex(nums);

        Assert.Equal(expected, actual);
    }
}
