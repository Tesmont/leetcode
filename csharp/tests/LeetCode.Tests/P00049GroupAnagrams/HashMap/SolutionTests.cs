using LeetCode.P00049GroupAnagrams.HashMap;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00049GroupAnagrams.SolutionTestCases;

namespace LeetCode.Tests.P00049GroupAnagrams.HashMap;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.GroupAnagramsCases), MemberType = typeof(RootSolutionTestCases))]
    public void GroupAnagrams_ReturnsGroupedAnagrams(string[] strs, string[][] expected)
    {
        Solution solution = new();

        IList<IList<string>> actual = solution.GroupAnagrams(strs);

        Assert.Equal(Normalize(expected), Normalize(actual));
    }

    private static string[][] Normalize(IEnumerable<IEnumerable<string>> groups)
    {
        return groups
            .Select(group => group.Order().ToArray())
            .OrderBy(group => group[0])
            .ThenBy(group => group.Length)
            .ToArray();
    }
}
