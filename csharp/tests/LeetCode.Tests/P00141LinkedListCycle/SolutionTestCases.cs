using Xunit;

namespace LeetCode.Tests.P00141LinkedListCycle;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, bool> HasCycleCases =>
        new()
        {
            { [3, 2, 0, -4], 1, true },
            { [1, 2], 0, true },
            { [1], -1, false },
            { [], -1, false },
        };
}
