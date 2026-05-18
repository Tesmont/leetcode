using LeetCode.P00930BinarySubarraysWithSum;
using Xunit;

namespace LeetCode.Tests.P00930BinarySubarraysWithSum;

public sealed class SolutionTests
{
    public static TheoryData<int[], int, int> NumSubarraysWithSumCases =>
        new()
        {
            { [1, 0, 1, 0, 1], 2, 4 },
            { [0, 0, 0, 0, 0], 0, 15 },
            { [1], 1, 1 },
            { [0], 1, 0 },
        };

    [Theory]
    [MemberData(nameof(NumSubarraysWithSumCases))]
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
