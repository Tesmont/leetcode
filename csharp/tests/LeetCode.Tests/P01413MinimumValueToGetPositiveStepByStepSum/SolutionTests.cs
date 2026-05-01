using LeetCode.P01413MinimumValueToGetPositiveStepByStepSum;
using Xunit;

namespace LeetCode.Tests.P01413MinimumValueToGetPositiveStepByStepSum;

public sealed class SolutionTests
{
    public static TheoryData<int[], int> MinStartValueCases =>
        new()
        {
            { [-3, 2, -3, 4, 2], 5 },
            { [1, 2], 1 },
            { [1, -2, -3], 5 },
        };

    [Theory]
    [MemberData(nameof(MinStartValueCases))]
    public void MinStartValue_ReturnsExpectedMinimumValue(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MinStartValue(nums);

        Assert.Equal(expected, actual);
    }
}
