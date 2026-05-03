using LeetCode.P00283MoveZeroes.SinglePass;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00283MoveZeroes.SolutionTestCases;

namespace LeetCode.Tests.P00283MoveZeroes.SinglePass;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MoveZeroesCases), MemberType = typeof(RootSolutionTestCases))]
    public void MoveZeroes_MovesZeroesToEndInPlace(int[] nums, int[] expected)
    {
        Solution solution = new();

        solution.MoveZeroes(nums);

        Assert.Equal(expected, nums);
    }
}
