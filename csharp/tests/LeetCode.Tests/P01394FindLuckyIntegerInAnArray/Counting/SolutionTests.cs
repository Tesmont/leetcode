using LeetCode.P01394FindLuckyIntegerInAnArray.Counting;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01394FindLuckyIntegerInAnArray.SolutionTestCases;

namespace LeetCode.Tests.P01394FindLuckyIntegerInAnArray.Counting;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.FindLuckyCases), MemberType = typeof(RootSolutionTestCases))]
    public void FindLucky_ReturnsLargestIntegerWhoseFrequencyEqualsItsValue(int[] arr, int expected)
    {
        Solution solution = new();

        int actual = solution.FindLucky(arr);

        Assert.Equal(expected, actual);
    }
}
