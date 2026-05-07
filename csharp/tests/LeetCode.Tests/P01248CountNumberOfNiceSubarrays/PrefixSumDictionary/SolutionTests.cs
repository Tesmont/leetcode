using LeetCode.P01248CountNumberOfNiceSubarrays.PrefixSumDictionary;
using Xunit;
using RootSolutionTests = LeetCode.Tests.P01248CountNumberOfNiceSubarrays.SolutionTests;

namespace LeetCode.Tests.P01248CountNumberOfNiceSubarrays.PrefixSumDictionary;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTests.NumberOfSubarraysCases), MemberType = typeof(RootSolutionTests))]
    public void NumberOfSubarrays_ReturnsNiceSubarrayCount(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.NumberOfSubarrays(nums, k);

        Assert.Equal(expected, actual);
    }
}
