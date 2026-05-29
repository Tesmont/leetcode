using LeetCode.P00001TwoSum;
using Xunit;

namespace LeetCode.Tests.P00001TwoSum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.TwoSumCases), MemberType = typeof(SolutionTestCases))]
    public void TwoSum_ReturnsIndicesOfNumbersAddingToTarget(int[] nums, int target, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.TwoSum(nums, target);

        Assert.Equal(expected, actual);
    }
}
