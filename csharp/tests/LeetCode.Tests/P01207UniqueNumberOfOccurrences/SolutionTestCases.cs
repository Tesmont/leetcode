using Xunit;

namespace LeetCode.Tests.P01207UniqueNumberOfOccurrences;

public static class SolutionTestCases
{
    public static TheoryData<int[], bool> UniqueOccurrencesCases =>
        new()
        {
            { [1, 2, 2, 1, 1, 3], true },
            { [1, 2], false },
            { [-3, 0, 1, -3, 1, 1, 1, -3, 10, 0], true },
            { [1, 1, 2, 2], false },
        };
}
