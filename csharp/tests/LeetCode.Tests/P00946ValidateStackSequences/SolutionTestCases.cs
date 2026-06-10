using Xunit;

namespace LeetCode.Tests.P00946ValidateStackSequences;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[], bool> ValidateStackSequencesCases =>
        new()
        {
            { [1, 2, 3, 4, 5], [4, 5, 3, 2, 1], true },
            { [1, 2, 3, 4, 5], [4, 3, 5, 1, 2], false },
            { [1], [1], true },
            { [1, 2], [2, 1], true },
            { [1, 2], [1, 2], true },
            { [2, 3, 0, 1], [0, 3, 2, 1], true }
        };
}
