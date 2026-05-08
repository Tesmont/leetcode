using LeetCode.P00525ContiguousArray.Dictionary;
using Xunit;

namespace LeetCode.Tests.P00525ContiguousArray.Dictionary;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(
        nameof(P00525ContiguousArray.SolutionTestCases.FindMaxLengthCases),
        MemberType = typeof(P00525ContiguousArray.SolutionTestCases))]
    public void FindMaxLength_ReturnsLongestContiguousSubarrayLength(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.FindMaxLength(nums);

        Assert.Equal(expected, actual);
    }
}
