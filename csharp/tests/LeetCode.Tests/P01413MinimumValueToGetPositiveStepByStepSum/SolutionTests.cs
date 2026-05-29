using LeetCode.P01413MinimumValueToGetPositiveStepByStepSum;
using Xunit;

namespace LeetCode.Tests.P01413MinimumValueToGetPositiveStepByStepSum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.MinStartValueCases), MemberType = typeof(SolutionTestCases))]
    public void MinStartValue_ReturnsExpectedMinimumValue(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MinStartValue(nums);

        Assert.Equal(expected, actual);
    }
}
