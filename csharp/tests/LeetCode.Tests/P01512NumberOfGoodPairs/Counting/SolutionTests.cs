using LeetCode.P01512NumberOfGoodPairs.Counting;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01512NumberOfGoodPairs.SolutionTestCases;

namespace LeetCode.Tests.P01512NumberOfGoodPairs.Counting;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.NumIdenticalPairsCases), MemberType = typeof(RootSolutionTestCases))]
    public void NumIdenticalPairs_ReturnsNumberOfGoodPairs(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.NumIdenticalPairs(nums);

        Assert.Equal(expected, actual);
    }
}
