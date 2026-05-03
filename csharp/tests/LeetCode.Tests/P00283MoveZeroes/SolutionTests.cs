using LeetCode.P00283MoveZeroes;
using Xunit;

namespace LeetCode.Tests.P00283MoveZeroes;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.MoveZeroesCases), MemberType = typeof(SolutionTestCases))]
    public void MoveZeroes_MovesZeroesToEndInPlace(int[] nums, int[] expected)
    {
        Solution solution = new();

        solution.MoveZeroes(nums);

        Assert.Equal(expected, nums);
    }
}
