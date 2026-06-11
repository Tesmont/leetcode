using Xunit;

namespace LeetCode.Tests.P00225ImplementStackUsingQueues;

public static class SolutionTestCases
{
    public static TheoryData<string[], int?[], object?[]> MyStackCases =>
        new()
        {
            {
                ["Push", "Push", "Top", "Pop", "Empty"],
                [1, 2, null, null, null],
                [null, null, 2, 2, false]
            },
            {
                ["Empty", "Push", "Empty", "Top", "Pop", "Empty"],
                [null, 1, null, null, null, null],
                [true, null, false, 1, 1, true]
            },
            {
                ["Push", "Push", "Push", "Top", "Pop", "Top", "Pop", "Top", "Empty"],
                [1, 2, 3, null, null, null, null, null, null],
                [null, null, null, 3, 3, 2, 2, 1, false]
            },
        };
}
