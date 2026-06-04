using LeetCode.P00643MaximumAverageSubarrayI.SlidingWindow;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00643MaximumAverageSubarrayI.SolutionTestCases;

namespace LeetCode.Tests.P00643MaximumAverageSubarrayI.SlidingWindow;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.FindMaxAverageCases), MemberType = typeof(RootSolutionTestCases))]
    public void FindMaxAverage_ReturnsExpectedMaximumAverage(int[] nums, int k, double expected)
    {
        Solution solution = new();

        double actual = solution.FindMaxAverage(nums, k);

        Assert.Equal(expected, actual, precision: 5);
    }
}
