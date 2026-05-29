using LeetCode.P00567PermutationInString;
using Xunit;

namespace LeetCode.Tests.P00567PermutationInString;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.CheckInclusionCases), MemberType = typeof(SolutionTestCases))]
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
