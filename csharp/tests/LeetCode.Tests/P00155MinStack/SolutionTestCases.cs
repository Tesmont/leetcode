using Xunit;

namespace LeetCode.Tests.P00155MinStack;

public static class SolutionTestCases
{
    public static TheoryData<string[], int?[], object?[]> MinStackCases =>
        new()
        {
            {
                ["Push", "Push", "Push", "GetMin", "Pop", "Top", "GetMin"],
                [-2, 0, -3, null, null, null, null],
                [null, null, null, -3, null, 0, -2]
            },
        };
}
