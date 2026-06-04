using LeetCode.P01480RunningSumOf1dArray.PrefixSum;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01480RunningSumOf1dArray.SolutionTestCases;

namespace LeetCode.Tests.P01480RunningSumOf1dArray.PrefixSum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.RunningSumCases), MemberType = typeof(RootSolutionTestCases))]
    public void RunningSum_ReturnsExpectedArray(int[] nums, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.RunningSum(nums);

        Assert.Equal(expected, actual);
    }
}
