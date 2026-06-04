using Xunit;

namespace LeetCode.Tests.P00933NumberOfRecentCalls;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> PingCases =>
        new()
        {
            { [1, 100, 3001, 3002], [1, 2, 3, 3] },
        };
}
