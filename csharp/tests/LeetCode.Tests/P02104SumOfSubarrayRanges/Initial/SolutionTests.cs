using LeetCode.P02104SumOfSubarrayRanges.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02104SumOfSubarrayRanges.SolutionTestCases;

namespace LeetCode.Tests.P02104SumOfSubarrayRanges.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.SubArrayRangesCases), MemberType = typeof(RootSolutionTestCases))]
    public void SubArrayRanges_ReturnsSumOfSubarrayRanges(int[] nums, long expected)
    {
        Solution solution = new();

        long actual = solution.SubArrayRanges(nums);

        Assert.Equal(expected, actual);
    }
}
