using Xunit;

namespace LeetCode.Tests.P00515FindLargestValueInEachTreeRow;

public static class SolutionTestCases
{
    public static TheoryData<int?[], int[]> LargestValuesCases =>
        new()
        {
            { [1, 3, 2, 5, 3, null, 9], [1, 3, 9] },
            { [1, 2, 3], [1, 3] },
            { [], [] },
            { [-1, -2, -3], [-1, -2] },
        };
}
