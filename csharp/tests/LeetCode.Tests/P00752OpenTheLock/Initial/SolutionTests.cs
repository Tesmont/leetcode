using LeetCode.P00752OpenTheLock.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00752OpenTheLock.SolutionTestCases;

namespace LeetCode.Tests.P00752OpenTheLock.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.OpenLockCases), MemberType = typeof(RootSolutionTestCases))]
    public void OpenLock_ReturnsMinimumNumberOfTurns(string[] deadends, string target, int expected)
    {
        Solution solution = new();

        int actual = solution.OpenLock(deadends, target);

        Assert.Equal(expected, actual);
    }
}
