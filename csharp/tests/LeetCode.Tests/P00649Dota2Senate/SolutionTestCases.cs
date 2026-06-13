using Xunit;

namespace LeetCode.Tests.P00649Dota2Senate;

public static class SolutionTestCases
{
    public static TheoryData<string, string> PredictPartyVictoryCases =>
        new()
        {
            { "RD", "Radiant" },
            { "RDD", "Dire" },
        };
}
