using LeetCode.P02342MaxSumOfAPairWithEqualSumOfDigits;
using Xunit;

namespace LeetCode.Tests.P02342MaxSumOfAPairWithEqualSumOfDigits;

public sealed class SolutionTests
{
    public static TheoryData<int[], int> MaximumSumCases =>
        new()
        {
            { [18, 43, 36, 13, 7], 54 },
            { [10, 12, 19, 14], -1 },
        };

    [Theory]
    [MemberData(nameof(MaximumSumCases))]
    public void MaximumSum_ReturnsMaxSumOfPairWithEqualSumOfDigits(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MaximumSum(nums);

        Assert.Equal(expected, actual);
    }
}
