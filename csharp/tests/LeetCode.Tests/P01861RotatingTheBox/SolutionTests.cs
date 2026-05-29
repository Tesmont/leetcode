using LeetCode.P01861RotatingTheBox;
using Xunit;

namespace LeetCode.Tests.P01861RotatingTheBox;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.RotateTheBoxCases), MemberType = typeof(SolutionTestCases))]
    public void RotateTheBox_ReturnsRotatedBoxAfterStonesFall(char[][] box, char[][] expected)
    {
        Solution solution = new();

        char[][] actual = solution.RotateTheBox(box);

        Assert.Equal(expected, actual);
    }
}
