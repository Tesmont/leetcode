using LeetCode.P00724FindPivotIndex;
using Xunit;

namespace LeetCode.Tests.P00724FindPivotIndex;

public sealed class SolutionTests
{
    public static TheoryData<int[], int> PivotIndexCases =>
        new()
        {
            { [1, 7, 3, 6, 5, 6], 3 },
            { [1, 2, 3], -1 },
            { [2, 1, -1], 0 },
        };

    [Theory]
    [MemberData(nameof(PivotIndexCases))]
    public void PivotIndex_ReturnsExpectedIndex(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.PivotIndex(nums);

        Assert.Equal(expected, actual);
    }
}
