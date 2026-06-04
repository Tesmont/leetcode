using LeetCode.P00933NumberOfRecentCalls.Queue;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00933NumberOfRecentCalls.SolutionTestCases;

namespace LeetCode.Tests.P00933NumberOfRecentCalls.Queue;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.PingCases), MemberType = typeof(RootSolutionTestCases))]
    public void Ping_ReturnsRecentCallCount(int[] pings, int[] expected)
    {
        RecentCounter recentCounter = new();
        int[] actual = new int[pings.Length];

        for (int i = 0; i < pings.Length; i++)
        {
            actual[i] = recentCounter.Ping(pings[i]);
        }

        Assert.Equal(expected, actual);
    }
}
