using LeetCode.P00451SortCharactersByFrequency.FrequencyCounting;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00451SortCharactersByFrequency.SolutionTestCases;

namespace LeetCode.Tests.P00451SortCharactersByFrequency.FrequencyCounting;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.FrequencySortCases), MemberType = typeof(RootSolutionTestCases))]
    public void FrequencySort_ReturnsCharactersSortedByDescendingFrequency(string s)
    {
        Solution solution = new();

        string actual = solution.FrequencySort(s);

        AssertSameCharacters(s, actual);
        AssertCharactersAreSortedByDescendingFrequency(actual);
    }

    private static void AssertSameCharacters(string expected, string actual)
    {
        Assert.Equal(expected.Length, actual.Length);

        Dictionary<char, int> expectedCounts = CountCharacters(expected);
        Dictionary<char, int> actualCounts = CountCharacters(actual);

        Assert.Equal(expectedCounts, actualCounts);
    }

    private static void AssertCharactersAreSortedByDescendingFrequency(string actual)
    {
        Dictionary<char, int> counts = CountCharacters(actual);

        int previousFrequency = int.MaxValue;
        for (int i = 0; i < actual.Length;)
        {
            char current = actual[i];
            int frequency = counts[current];

            Assert.True(frequency <= previousFrequency);
            previousFrequency = frequency;

            while (i < actual.Length && actual[i] == current)
            {
                i++;
            }
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
