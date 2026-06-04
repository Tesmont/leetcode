using LeetCode.P01413MinimumValueToGetPositiveStepByStepSum.PrefixSum;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01413MinimumValueToGetPositiveStepByStepSum.SolutionTestCases;

namespace LeetCode.Tests.P01413MinimumValueToGetPositiveStepByStepSum.PrefixSum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MinStartValueCases), MemberType = typeof(RootSolutionTestCases))]
    public void MinStartValue_ReturnsExpectedMinimumValue(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MinStartValue(nums);

        Assert.Equal(expected, actual);
    }
}
