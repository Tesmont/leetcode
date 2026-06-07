using LeetCode.P02390RemovingStarsFromAString.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02390RemovingStarsFromAString.SolutionTestCases;

namespace LeetCode.Tests.P02390RemovingStarsFromAString.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.RemoveStarsCases), MemberType = typeof(RootSolutionTestCases))]
    public void RemoveStars_ReturnsStringAfterRemovingStars(string s, string expected)
    {
        Solution solution = new();

        string actual = solution.RemoveStars(s);

        Assert.Equal(expected, actual);
    }
}
