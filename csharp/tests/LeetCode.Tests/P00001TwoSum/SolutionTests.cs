using LeetCode.P00001TwoSum;
using Xunit;

namespace LeetCode.Tests.P00001TwoSum;

public sealed class SolutionTests
{
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void TwoSum_ReturnsIndicesOfNumbersAddingToTarget(int[] nums, int target, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.TwoSum(nums, target);

        Assert.Equal(expected, actual);
    }
}
