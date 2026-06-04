using LeetCode.P01248CountNumberOfNiceSubarrays.PrefixSum;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01248CountNumberOfNiceSubarrays.SolutionTestCases;

namespace LeetCode.Tests.P01248CountNumberOfNiceSubarrays.PrefixSum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.NumberOfSubarraysCases), MemberType = typeof(RootSolutionTestCases))]
    public void NumberOfSubarrays_ReturnsNiceSubarrayCount(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.NumberOfSubarrays(nums, k);

        Assert.Equal(expected, actual);
    }
}
