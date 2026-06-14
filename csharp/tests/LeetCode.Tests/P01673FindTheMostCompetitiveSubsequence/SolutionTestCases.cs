using Xunit;

namespace LeetCode.Tests.P01673FindTheMostCompetitiveSubsequence;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, int[]> MostCompetitiveCases =>
        new()
        {
            { [3, 5, 2, 6], 2, [2, 6] },
            { [2, 4, 3, 3, 5, 4, 9, 6], 4, [2, 3, 3, 4] },
            { [1], 1, [1] },
            { [5, 4, 3, 2, 1], 3, [3, 2, 1] },
            { [1, 2, 3, 4, 5], 3, [1, 2, 3] },
            { [2, 1, 2, 1, 2], 3, [1, 1, 2] },
        };
}
