using LeetCode.P01861RotatingTheBox.Simulation;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01861RotatingTheBox.SolutionTestCases;

namespace LeetCode.Tests.P01861RotatingTheBox.Simulation;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.RotateTheBoxCases), MemberType = typeof(RootSolutionTestCases))]
    public void RotateTheBox_ReturnsRotatedBoxAfterStonesFall(char[][] box, char[][] expected)
    {
        Solution solution = new();

        char[][] actual = solution.RotateTheBox(box);

        Assert.Equal(expected, actual);
    }
}
