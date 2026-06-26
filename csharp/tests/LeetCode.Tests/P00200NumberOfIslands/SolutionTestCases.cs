using Xunit;

namespace LeetCode.Tests.P00200NumberOfIslands;

public static class SolutionTestCases
{
    public static TheoryData<char[][], int> NumIslandsCases =>
        new()
        {
            {
                [
                    ['1', '1', '1', '1', '0'],
                    ['1', '1', '0', '1', '0'],
                    ['1', '1', '0', '0', '0'],
                    ['0', '0', '0', '0', '0'],
                ],
                1
            },
            {
                [
                    ['1', '1', '0', '0', '0'],
                    ['1', '1', '0', '0', '0'],
                    ['0', '0', '1', '0', '0'],
                    ['0', '0', '0', '1', '1'],
                ],
                3
            },
        };
}
