using LeetCode.P01004MaxConsecutiveOnesIII;
using Xunit;

namespace LeetCode.Tests.P01004MaxConsecutiveOnesIII;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.LongestOnesCases), MemberType = typeof(SolutionTestCases))]
    public void LongestOnes_ReturnsExpectedLength(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.LongestOnes(nums, k);

        Assert.Equal(expected, actual);
    }
}
