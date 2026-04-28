using LeetCode.P00643MaximumAverageSubarrayI;
using Xunit;

namespace LeetCode.Tests.P00643MaximumAverageSubarrayI;

public sealed class SolutionTests
{
    public static TheoryData<int[], int, double> FindMaxAverageCases =>
        new()
        {
            { [1, 12, -5, -6, 50, 3], 4, 12.75 },
            { [5], 1, 5.0 },
        };

    [Theory]
    [MemberData(nameof(FindMaxAverageCases))]
    public void FindMaxAverage_ReturnsExpectedMaximumAverage(int[] nums, int k, double expected)
    {
        Solution solution = new();

        double actual = solution.FindMaxAverage(nums, k);

        Assert.Equal(expected, actual, precision: 5);
    }
}
