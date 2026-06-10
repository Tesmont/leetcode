using Xunit;

namespace LeetCode.Tests.P00735AsteroidCollision;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> AsteroidCollisionCases =>
        new()
        {
            { [5, 10, -5], [5, 10] },
            { [8, -8], [] },
            { [10, 2, -5], [10] },
            { [-2, -1, 1, 2], [-2, -1, 1, 2] },
            { [1, -2, -2, -2], [-2, -2, -2] }
        };
}
