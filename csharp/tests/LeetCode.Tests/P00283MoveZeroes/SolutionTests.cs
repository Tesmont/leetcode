using LeetCode.P00283MoveZeroes;
using Xunit;

namespace LeetCode.Tests.P00283MoveZeroes;

public sealed class SolutionTests
{
    public static TheoryData<int[], int[]> MoveZeroesCases =>
        new()
        {
            { [0, 1, 0, 3, 12], [1, 3, 12, 0, 0] },
            { [0], [0] },
            { [1, 0, 1], [1, 1, 0] },
            { [1, 2, 3], [1, 2, 3] },
            { [0, 0, 1], [1, 0, 0] },
        };

    [Theory]
    [MemberData(nameof(MoveZeroesCases))]
    public void MoveZeroes_MovesZeroesToEndInPlace(int[] nums, int[] expected)
    {
        Solution solution = new();

        solution.MoveZeroes(nums);

        Assert.Equal(expected, nums);
    }
}
