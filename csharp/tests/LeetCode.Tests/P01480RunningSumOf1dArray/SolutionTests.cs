using LeetCode.P01480RunningSumOf1dArray;
using Xunit;

namespace LeetCode.Tests.P01480RunningSumOf1dArray;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.RunningSumCases), MemberType = typeof(SolutionTestCases))]
    public void RunningSum_ReturnsExpectedArray(int[] nums, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.RunningSum(nums);

        Assert.Equal(expected, actual);
    }
}
