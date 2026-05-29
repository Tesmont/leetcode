using LeetCode.P01248CountNumberOfNiceSubarrays.PrefixSumDictionary;
using Xunit;

namespace LeetCode.Tests.P01248CountNumberOfNiceSubarrays.PrefixSumDictionary;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.NumberOfSubarraysCases), MemberType = typeof(SolutionTestCases))]
    public void NumberOfSubarrays_ReturnsNiceSubarrayCount(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.NumberOfSubarrays(nums, k);

        Assert.Equal(expected, actual);
    }
}
