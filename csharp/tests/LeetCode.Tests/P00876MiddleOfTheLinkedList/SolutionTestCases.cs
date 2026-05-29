using Xunit;

namespace LeetCode.Tests.P00876MiddleOfTheLinkedList;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> MiddleNodeCases =>
        new()
        {
            { [1, 2, 3, 4, 5], 2 },
            { [1, 2, 3, 4, 5, 6], 3 },
        };
}
