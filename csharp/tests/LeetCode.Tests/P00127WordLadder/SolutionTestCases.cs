using Xunit;

namespace LeetCode.Tests.P00127WordLadder;

public static class SolutionTestCases
{
    public static TheoryData<string, string, IList<string>, int> LadderLengthCases =>
        new()
        {
            { "hit", "cog", ["hot", "dot", "dog", "lot", "log", "cog"], 5 },
            { "hit", "cog", ["hot", "dot", "dog", "lot", "log"], 0 },
        };
}
