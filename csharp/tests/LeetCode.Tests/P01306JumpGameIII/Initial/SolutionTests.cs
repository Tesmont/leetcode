using LeetCode.P01306JumpGameIII.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01306JumpGameIII.SolutionTestCases;

namespace LeetCode.Tests.P01306JumpGameIII.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.CanReachCases), MemberType = typeof(RootSolutionTestCases))]
    public void CanReach_ReturnsWhetherZeroIsReachable(int[] arr, int start, bool expected)
    {
        Solution solution = new();

        bool actual = solution.CanReach(arr, start);

        Assert.Equal(expected, actual);
    }
}
