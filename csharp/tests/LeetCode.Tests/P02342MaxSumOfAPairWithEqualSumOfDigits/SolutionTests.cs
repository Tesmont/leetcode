using LeetCode.P02342MaxSumOfAPairWithEqualSumOfDigits;
using Xunit;

namespace LeetCode.Tests.P02342MaxSumOfAPairWithEqualSumOfDigits;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.MaximumSumCases), MemberType = typeof(SolutionTestCases))]
    public void MaximumSum_ReturnsMaxSumOfPairWithEqualSumOfDigits(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MaximumSum(nums);

        Assert.Equal(expected, actual);
    }
}
