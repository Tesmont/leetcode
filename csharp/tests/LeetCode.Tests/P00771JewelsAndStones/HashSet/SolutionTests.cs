using LeetCode.P00771JewelsAndStones.HashSet;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00771JewelsAndStones.SolutionTestCases;

namespace LeetCode.Tests.P00771JewelsAndStones.HashSet;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.NumJewelsInStonesCases), MemberType = typeof(RootSolutionTestCases))]
    public void NumJewelsInStones_ReturnsNumberOfStonesThatAreJewels(
        string jewels,
        string stones,
        int expected)
    {
        Solution solution = new();

        int actual = solution.NumJewelsInStones(jewels, stones);

        Assert.Equal(expected, actual);
    }
}
