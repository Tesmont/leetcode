using LeetCode.P00560SubarraySumEqualsK;
using Xunit;

namespace LeetCode.Tests.P00560SubarraySumEqualsK;

public sealed class SolutionTests
{
    public static TheoryData<int[], int, int> SubarraySumCases =>
        new()
        {
            { [1, 1, 1], 2, 2 },
            { [1, 2, 3], 3, 2 },
            { [3], 3, 1 },
            { [1], 0, 0 },
            { [1, -1, 0], 0, 3 },
            { [0, 0, 0], 0, 6 },
            { [1, -1, 1, -1], 0, 4 },
            { [3, 4, 7, 2, -3, 1, 4, 2], 7, 4 },
            { [-1, -1, 1], 0, 1 },
        };

    [Theory]
    [MemberData(nameof(SubarraySumCases))]
    public void SubarraySum_ReturnsCountOfSubarraysWithTargetSum(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.SubarraySum(nums, k);

        Assert.Equal(expected, actual);
    }
}
