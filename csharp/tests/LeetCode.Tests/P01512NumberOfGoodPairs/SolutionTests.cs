using LeetCode.P01512NumberOfGoodPairs;
using Xunit;

namespace LeetCode.Tests.P01512NumberOfGoodPairs;

public sealed class SolutionTests
{
    public static TheoryData<int[], int> NumIdenticalPairsCases =>
        new()
        {
            { [1, 2, 3, 1, 1, 3], 4 },
            { [1, 1, 1, 1], 6 },
            { [1, 2, 3], 0 },
            { [5], 0 },
        };

    [Theory]
    [MemberData(nameof(NumIdenticalPairsCases))]
    public void NumIdenticalPairs_ReturnsNumberOfGoodPairs(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.NumIdenticalPairs(nums);

        Assert.Equal(expected, actual);
    }
}
