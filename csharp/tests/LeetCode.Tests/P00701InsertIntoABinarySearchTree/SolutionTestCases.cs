using Xunit;

namespace LeetCode.Tests.P00701InsertIntoABinarySearchTree;

public static class SolutionTestCases
{
    public static TheoryData<int?[], int, int?[]> InsertIntoBSTCases =>
        new()
        {
            { [4, 2, 7, 1, 3], 5, [4, 2, 7, 1, 3, 5] },
            { [40, 20, 60, 10, 30, 50, 70], 25, [40, 20, 60, 10, 30, 50, 70, null, null, 25] },
            { [], 5, [5] },
        };
}
