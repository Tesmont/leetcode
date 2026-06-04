using LeetCode.P00933NumberOfRecentCalls;
using Xunit;

namespace LeetCode.Tests.P00933NumberOfRecentCalls;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.PingCases), MemberType = typeof(SolutionTestCases))]
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
