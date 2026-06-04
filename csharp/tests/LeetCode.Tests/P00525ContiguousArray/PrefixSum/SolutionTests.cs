using LeetCode.P00525ContiguousArray.PrefixSum;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00525ContiguousArray.SolutionTestCases;

namespace LeetCode.Tests.P00525ContiguousArray.PrefixSum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.FindMaxLengthCases), MemberType = typeof(RootSolutionTestCases))]
    public void FindMaxLength_ReturnsLongestContiguousSubarrayLength(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.FindMaxLength(nums);

        Assert.Equal(expected, actual);
    }
}
