using LeetCode.P01695MaximumErasureValue;
using Xunit;

namespace LeetCode.Tests.P01695MaximumErasureValue;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.MaximumUniqueSubarrayCases), MemberType = typeof(SolutionTestCases))]
    public void MaximumUniqueSubarray_ReturnsMaximumSumOfUniqueSubarray(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MaximumUniqueSubarray(nums);

        Assert.Equal(expected, actual);
    }
}
