using LeetCode.P01394FindLuckyIntegerInAnArray;
using Xunit;

namespace LeetCode.Tests.P01394FindLuckyIntegerInAnArray;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.FindLuckyCases), MemberType = typeof(SolutionTestCases))]
    public void FindLucky_ReturnsLargestIntegerWhoseFrequencyEqualsItsValue(int[] arr, int expected)
    {
        Solution solution = new();

        int actual = solution.FindLucky(arr);

        Assert.Equal(expected, actual);
    }
}
