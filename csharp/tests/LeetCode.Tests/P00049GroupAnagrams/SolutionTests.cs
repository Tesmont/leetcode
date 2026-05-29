using LeetCode.P00049GroupAnagrams;
using Xunit;

namespace LeetCode.Tests.P00049GroupAnagrams;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.GroupAnagramsCases), MemberType = typeof(SolutionTestCases))]
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
