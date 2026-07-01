using LeetCode.P01926NearestExitFromEntranceInMaze.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01926NearestExitFromEntranceInMaze.SolutionTestCases;

namespace LeetCode.Tests.P01926NearestExitFromEntranceInMaze.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(
        nameof(RootSolutionTestCases.NearestExitCases),
        MemberType = typeof(RootSolutionTestCases))]
    public void NearestExit_ReturnsMinimumNumberOfSteps(char[][] maze, int[] entrance, int expected)
    {
        Solution solution = new();

        int actual = solution.NearestExit(maze, entrance);

        Assert.Equal(expected, actual);
    }
}
