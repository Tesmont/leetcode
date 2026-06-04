using LeetCode.P01991FindTheMiddleIndexInArray.PrefixSum;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01991FindTheMiddleIndexInArray.SolutionTestCases;

namespace LeetCode.Tests.P01991FindTheMiddleIndexInArray.PrefixSum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.FindMiddleIndexCases), MemberType = typeof(RootSolutionTestCases))]
    public void FindMiddleIndex_ReturnsExpectedIndex(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.FindMiddleIndex(nums);

        Assert.Equal(expected, actual);
    }
}
