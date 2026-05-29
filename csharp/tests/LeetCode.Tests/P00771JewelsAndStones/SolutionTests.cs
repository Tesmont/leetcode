using LeetCode.P00771JewelsAndStones;
using Xunit;

namespace LeetCode.Tests.P00771JewelsAndStones;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.NumJewelsInStonesCases), MemberType = typeof(SolutionTestCases))]
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
