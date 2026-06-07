using Xunit;

namespace LeetCode.Tests.P00232ImplementQueueUsingStacks;

public static class SolutionTestCases
{
    public static TheoryData<string[], int?[], object?[]> ImplementQueueUsingStacksCases =>
        new()
        {
            {
                ["Push", "Push", "Peek", "Pop", "Empty"],
                [1, 2, null, null, null],
                [null, null, 1, 1, false]
            },
        };
}
