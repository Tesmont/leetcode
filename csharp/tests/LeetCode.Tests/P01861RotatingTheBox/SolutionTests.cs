using LeetCode.P01861RotatingTheBox;
using Xunit;

namespace LeetCode.Tests.P01861RotatingTheBox;

public sealed class SolutionTests
{
    public static TheoryData<char[][], char[][]> RotateTheBoxCases =>
        new()
        {
            {
                [
                    ['#', '.', '#'],
                ],
                [
                    ['.'],
                    ['#'],
                    ['#'],
                ]
            },
            {
                [
                    ['#', '.', '*', '.'],
                    ['#', '#', '*', '.'],
                ],
                [
                    ['#', '.'],
                    ['#', '#'],
                    ['*', '*'],
                    ['.', '.'],
                ]
            },
            {
                [
                    ['#', '#', '*', '.', '*', '.'],
                    ['#', '#', '#', '*', '.', '.'],
                    ['#', '#', '#', '.', '#', '.'],
                ],
                [
                    ['.', '#', '#'],
                    ['.', '#', '#'],
                    ['#', '#', '*'],
                    ['#', '*', '.'],
                    ['#', '.', '*'],
                    ['#', '.', '.'],
                ]
            },
        };

    [Theory]
    [MemberData(nameof(RotateTheBoxCases))]
    public void RotateTheBox_ReturnsRotatedBoxAfterStonesFall(char[][] box, char[][] expected)
    {
        Solution solution = new();

        char[][] actual = solution.RotateTheBox(box);

        Assert.Equal(expected, actual);
    }
}
