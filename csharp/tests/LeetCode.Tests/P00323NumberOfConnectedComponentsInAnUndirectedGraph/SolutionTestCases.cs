using Xunit;

namespace LeetCode.Tests.P00323NumberOfConnectedComponentsInAnUndirectedGraph;

public static class SolutionTestCases
{
    public static TheoryData<int, int[][], int> CountComponentsCases =>
        new()
        {
            {
                5,
                [[0, 1], [1, 2], [3, 4]],
                2
            },
            {
                5,
                [[0, 1], [1, 2], [2, 3], [3, 4]],
                1
            },
            {
                1,
                [],
                1
            },
        };
}
