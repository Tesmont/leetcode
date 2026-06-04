using LeetCode.P00791CustomSortString.Counting;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00791CustomSortString.SolutionTestCases;

namespace LeetCode.Tests.P00791CustomSortString.Counting;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.CustomSortStringCases), MemberType = typeof(RootSolutionTestCases))]
    public void CustomSortString_ReturnsPermutationInCustomOrder(string order, string s)
    {
        Solution solution = new();

        string actual = solution.CustomSortString(order, s);

        AssertSameCharacters(s, actual);
        AssertCharactersFollowCustomOrder(order, actual);
    }

    private static void AssertSameCharacters(string expected, string actual)
    {
        Assert.Equal(expected.Length, actual.Length);

        Dictionary<char, int> expectedCounts = CountCharacters(expected);
        Dictionary<char, int> actualCounts = CountCharacters(actual);

        Assert.Equal(expectedCounts, actualCounts);
    }

    private static void AssertCharactersFollowCustomOrder(string order, string actual)
    {
        int previousOrderIndex = -1;
        for (int i = 0; i < actual.Length; i++)
        {
            int currentOrderIndex = order.IndexOf(actual[i], System.StringComparison.Ordinal);
            if (currentOrderIndex < 0)
            {
                continue;
            }

            Assert.True(currentOrderIndex >= previousOrderIndex);
            previousOrderIndex = currentOrderIndex;
        }
    }

    private static Dictionary<char, int> CountCharacters(string s)
    {
        Dictionary<char, int> counts = [];
        for (int i = 0; i < s.Length; i++)
        {
            counts.TryGetValue(s[i], out int count);
            counts[s[i]] = count + 1;
        }

        return counts;
    }
}
