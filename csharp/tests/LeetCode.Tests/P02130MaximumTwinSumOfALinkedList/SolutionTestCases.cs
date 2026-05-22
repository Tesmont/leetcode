using Xunit;

namespace LeetCode.Tests.P02130MaximumTwinSumOfALinkedList;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> PairSumCases =>
        new()
        {
            { [5, 4, 2, 1], 6 },
            { [4, 2, 2, 3], 7 },
            { [1, 100000], 100001 },
        };
}
