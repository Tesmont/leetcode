using LeetCode.P01207UniqueNumberOfOccurrences.Counting;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01207UniqueNumberOfOccurrences.SolutionTestCases;

namespace LeetCode.Tests.P01207UniqueNumberOfOccurrences.Counting;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.UniqueOccurrencesCases), MemberType = typeof(RootSolutionTestCases))]
    public void UniqueOccurrences_ReturnsWhetherEveryValueHasUniqueOccurrenceCount(int[] arr, bool expected)
    {
        Solution solution = new();

        bool actual = solution.UniqueOccurrences(arr);

        Assert.Equal(expected, actual);
    }
}
