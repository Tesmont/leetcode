using LeetCode.P00930BinarySubarraysWithSum;
using Xunit;

namespace LeetCode.Tests.P00930BinarySubarraysWithSum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.NumSubarraysWithSumCases), MemberType = typeof(SolutionTestCases))]
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
