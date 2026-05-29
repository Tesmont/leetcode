using Xunit;

namespace LeetCode.Tests.P00771JewelsAndStones;

public static class SolutionTestCases
{
    public static TheoryData<string, string, int> NumJewelsInStonesCases =>
        new()
        {
            { "aA", "aAAbbbb", 3 },
            { "z", "ZZ", 0 },
            { "A", "aA", 1 },
        };
}
