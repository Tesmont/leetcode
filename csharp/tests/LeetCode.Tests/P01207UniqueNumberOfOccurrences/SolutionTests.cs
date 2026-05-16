using LeetCode.P01207UniqueNumberOfOccurrences;
using Xunit;

namespace LeetCode.Tests.P01207UniqueNumberOfOccurrences;

public sealed class SolutionTests
{
    public static TheoryData<int[], bool> UniqueOccurrencesCases =>
        new()
        {
            { [1, 2, 2, 1, 1, 3], true },
            { [1, 2], false },
            { [-3, 0, 1, -3, 1, 1, 1, -3, 10, 0], true },
            { [1, 1, 2, 2], false },
        };

    [Theory]
    [MemberData(nameof(UniqueOccurrencesCases))]
    public void UniqueOccurrences_ReturnsWhetherEveryValueHasUniqueOccurrenceCount(int[] arr, bool expected)
    {
        Solution solution = new();

        bool actual = solution.UniqueOccurrences(arr);

        Assert.Equal(expected, actual);
    }
}
