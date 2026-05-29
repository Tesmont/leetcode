using LeetCode.P01512NumberOfGoodPairs;
using Xunit;

namespace LeetCode.Tests.P01512NumberOfGoodPairs;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.NumIdenticalPairsCases), MemberType = typeof(SolutionTestCases))]
    public void NumIdenticalPairs_ReturnsNumberOfGoodPairs(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.NumIdenticalPairs(nums);

        Assert.Equal(expected, actual);
    }
}
