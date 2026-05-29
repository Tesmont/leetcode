using LeetCode.P00643MaximumAverageSubarrayI;
using Xunit;

namespace LeetCode.Tests.P00643MaximumAverageSubarrayI;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.FindMaxAverageCases), MemberType = typeof(SolutionTestCases))]
    public void FindMaxAverage_ReturnsExpectedMaximumAverage(int[] nums, int k, double expected)
    {
        Solution solution = new();

        double actual = solution.FindMaxAverage(nums, k);

        Assert.Equal(expected, actual, precision: 5);
    }
}
