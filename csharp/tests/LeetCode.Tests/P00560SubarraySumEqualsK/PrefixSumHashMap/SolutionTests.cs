using LeetCode.P00560SubarraySumEqualsK.PrefixSumHashMap;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00560SubarraySumEqualsK.SolutionTestCases;

namespace LeetCode.Tests.P00560SubarraySumEqualsK.PrefixSumHashMap;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.SubarraySumCases), MemberType = typeof(RootSolutionTestCases))]
    public void SubarraySum_ReturnsCountOfSubarraysWithTargetSum(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.SubarraySum(nums, k);

        Assert.Equal(expected, actual);
    }
}
