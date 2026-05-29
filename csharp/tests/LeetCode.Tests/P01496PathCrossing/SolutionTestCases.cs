using Xunit;

namespace LeetCode.Tests.P01496PathCrossing;

public static class SolutionTestCases
{
    public static TheoryData<string, bool> IsPathCrossingCases =>
        new()
        {
            { "NES", false },
            { "NESWW", true },
        };
}
