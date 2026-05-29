using LeetCode.P02090KRadiusSubarrayAverages;
using Xunit;

namespace LeetCode.Tests.P02090KRadiusSubarrayAverages;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.GetAveragesCases), MemberType = typeof(SolutionTestCases))]
    public void GetAverages_ReturnsExpectedValues(int[] nums, int k, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.GetAverages(nums, k);

        Assert.Equal(expected, actual);
    }
}
