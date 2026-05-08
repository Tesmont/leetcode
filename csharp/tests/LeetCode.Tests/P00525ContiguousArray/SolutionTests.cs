using LeetCode.P00525ContiguousArray;
using Xunit;

namespace LeetCode.Tests.P00525ContiguousArray;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.FindMaxLengthCases), MemberType = typeof(SolutionTestCases))]
    public void FindMaxLength_ReturnsLongestContiguousSubarrayLength(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.FindMaxLength(nums);

        Assert.Equal(expected, actual);
    }
}
