using LeetCode.P00567PermutationInString.SlidingWindow;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00567PermutationInString.SolutionTestCases;

namespace LeetCode.Tests.P00567PermutationInString.SlidingWindow;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.CheckInclusionCases), MemberType = typeof(RootSolutionTestCases))]
    public void CheckInclusion_ReturnsWhetherS2ContainsPermutationOfS1(
        string s1,
        string s2,
        bool expected)
    {
        Solution solution = new();

        bool actual = solution.CheckInclusion(s1, s2);

        Assert.Equal(expected, actual);
    }
}
