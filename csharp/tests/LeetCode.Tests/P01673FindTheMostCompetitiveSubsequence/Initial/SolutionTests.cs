using LeetCode.P01673FindTheMostCompetitiveSubsequence.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01673FindTheMostCompetitiveSubsequence.SolutionTestCases;

namespace LeetCode.Tests.P01673FindTheMostCompetitiveSubsequence.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MostCompetitiveCases), MemberType = typeof(RootSolutionTestCases))]
    public void MostCompetitive_ReturnsMostCompetitiveSubsequence(int[] nums, int k, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.MostCompetitive(nums, k);

        Assert.Equal(expected, actual);
    }
}
