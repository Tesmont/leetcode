using Xunit;

namespace LeetCode.Tests.P01290ConvertBinaryNumberInALinkedListToInteger;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> GetDecimalValueCases =>
        new()
        {
            { [1, 0, 1], 5 },
            { [0], 0 },
            { [1], 1 },
            { [1, 0, 0, 1], 9 },
            { [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1], 1073741823 },
        };
}
