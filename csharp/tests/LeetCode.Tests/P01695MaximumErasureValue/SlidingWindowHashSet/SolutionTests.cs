using LeetCode.P01695MaximumErasureValue.SlidingWindowHashSet;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01695MaximumErasureValue.SolutionTestCases;

namespace LeetCode.Tests.P01695MaximumErasureValue.SlidingWindowHashSet;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MaximumUniqueSubarrayCases), MemberType = typeof(RootSolutionTestCases))]
    public void MaximumUniqueSubarray_ReturnsMaximumSumOfUniqueSubarray(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MaximumUniqueSubarray(nums);

        Assert.Equal(expected, actual);
    }
}
