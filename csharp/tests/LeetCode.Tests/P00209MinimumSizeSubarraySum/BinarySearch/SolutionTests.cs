using LeetCode.P00209MinimumSizeSubarraySum.BinarySearch;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00209MinimumSizeSubarraySum.SolutionTestCases;

namespace LeetCode.Tests.P00209MinimumSizeSubarraySum.BinarySearch;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MinSubArrayLenCases), MemberType = typeof(RootSolutionTestCases))]
    public void MinSubArrayLen_ReturnsExpectedLength(int target, int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MinSubArrayLen(target, nums);

        Assert.Equal(expected, actual);
    }
}
