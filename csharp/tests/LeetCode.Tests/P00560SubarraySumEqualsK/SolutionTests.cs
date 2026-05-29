using LeetCode.P00560SubarraySumEqualsK;
using Xunit;

namespace LeetCode.Tests.P00560SubarraySumEqualsK;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.SubarraySumCases), MemberType = typeof(SolutionTestCases))]
    public void SubarraySum_ReturnsCountOfSubarraysWithTargetSum(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.SubarraySum(nums, k);

        Assert.Equal(expected, actual);
    }
}
