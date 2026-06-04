using LeetCode.P02342MaxSumOfAPairWithEqualSumOfDigits.HashMap;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02342MaxSumOfAPairWithEqualSumOfDigits.SolutionTestCases;

namespace LeetCode.Tests.P02342MaxSumOfAPairWithEqualSumOfDigits.HashMap;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MaximumSumCases), MemberType = typeof(RootSolutionTestCases))]
    public void MaximumSum_ReturnsMaxSumOfPairWithEqualSumOfDigits(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MaximumSum(nums);

        Assert.Equal(expected, actual);
    }
}
