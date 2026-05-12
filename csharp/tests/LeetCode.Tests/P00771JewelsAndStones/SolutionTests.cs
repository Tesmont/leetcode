using LeetCode.P00771JewelsAndStones;
using Xunit;

namespace LeetCode.Tests.P00771JewelsAndStones;

public sealed class SolutionTests
{
    public static TheoryData<string, string, int> NumJewelsInStonesCases =>
        new()
        {
            { "aA", "aAAbbbb", 3 },
            { "z", "ZZ", 0 },
            { "A", "aA", 1 },
        };

    [Theory]
    [MemberData(nameof(NumJewelsInStonesCases))]
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
