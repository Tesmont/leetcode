using LeetCode.P02434UsingARobotToPrintTheLexicographicallySmallestString.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02434UsingARobotToPrintTheLexicographicallySmallestString.SolutionTestCases;

namespace LeetCode.Tests.P02434UsingARobotToPrintTheLexicographicallySmallestString.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.RobotWithStringCases), MemberType = typeof(RootSolutionTestCases))]
    public void RobotWithString_ReturnsLexicographicallySmallestString(string s, string expected)
    {
        Solution solution = new();

        string actual = solution.RobotWithString(s);

        Assert.Equal(expected, actual);
    }
}
