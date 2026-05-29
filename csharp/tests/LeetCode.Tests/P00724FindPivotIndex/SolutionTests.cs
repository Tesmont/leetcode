using LeetCode.P00724FindPivotIndex;
using Xunit;

namespace LeetCode.Tests.P00724FindPivotIndex;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.PivotIndexCases), MemberType = typeof(SolutionTestCases))]
    public void PivotIndex_ReturnsExpectedIndex(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.PivotIndex(nums);

        Assert.Equal(expected, actual);
    }
}
