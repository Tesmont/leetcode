using LeetCode.P01991FindTheMiddleIndexInArray;
using Xunit;

namespace LeetCode.Tests.P01991FindTheMiddleIndexInArray;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.FindMiddleIndexCases), MemberType = typeof(SolutionTestCases))]
    public void FindMiddleIndex_ReturnsExpectedIndex(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.FindMiddleIndex(nums);

        Assert.Equal(expected, actual);
    }
}
