using LeetCode.P00930BinarySubarraysWithSum.PrefixSum;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00930BinarySubarraysWithSum.SolutionTestCases;

namespace LeetCode.Tests.P00930BinarySubarraysWithSum.PrefixSum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.NumSubarraysWithSumCases), MemberType = typeof(RootSolutionTestCases))]
    public void NumSubarraysWithSum_ReturnsCountOfBinarySubarraysWithTargetSum(
        int[] nums,
        int goal,
        int expected)
    {
        Solution solution = new();

        int actual = solution.NumSubarraysWithSum(nums, goal);

        Assert.Equal(expected, actual);
    }
}
