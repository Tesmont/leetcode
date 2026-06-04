using LeetCode.P00001TwoSum.HashMap;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00001TwoSum.SolutionTestCases;

namespace LeetCode.Tests.P00001TwoSum.HashMap;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.TwoSumCases), MemberType = typeof(RootSolutionTestCases))]
    public void TwoSum_ReturnsIndicesOfNumbersAddingToTarget(int[] nums, int target, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.TwoSum(nums, target);

        Assert.Equal(expected, actual);
    }
}
