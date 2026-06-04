using LeetCode.P02090KRadiusSubarrayAverages.PrefixSum;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02090KRadiusSubarrayAverages.SolutionTestCases;

namespace LeetCode.Tests.P02090KRadiusSubarrayAverages.PrefixSum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.GetAveragesCases), MemberType = typeof(RootSolutionTestCases))]
    public void GetAverages_ReturnsExpectedValues(int[] nums, int k, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.GetAverages(nums, k);

        Assert.Equal(expected, actual);
    }
}
