using LeetCode.P01207UniqueNumberOfOccurrences;
using Xunit;

namespace LeetCode.Tests.P01207UniqueNumberOfOccurrences;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.UniqueOccurrencesCases), MemberType = typeof(SolutionTestCases))]
    public void UniqueOccurrences_ReturnsWhetherEveryValueHasUniqueOccurrenceCount(int[] arr, bool expected)
    {
        Solution solution = new();

        bool actual = solution.UniqueOccurrences(arr);

        Assert.Equal(expected, actual);
    }
}
