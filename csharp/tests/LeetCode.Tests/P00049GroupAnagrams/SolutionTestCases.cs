using Xunit;

namespace LeetCode.Tests.P00049GroupAnagrams;

public static class SolutionTestCases
{
    public static TheoryData<string[], string[][]> GroupAnagramsCases =>
        new()
        {
            { ["eat", "tea", "tan", "ate", "nat", "bat"], [["bat"], ["nat", "tan"], ["ate", "eat", "tea"]] },
            { [""], [[""]] },
            { ["a"], [["a"]] },
        };
}
