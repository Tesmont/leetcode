using LeetCode.P00239SlidingWindowMaximum.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00239SlidingWindowMaximum.SolutionTestCases;

namespace LeetCode.Tests.P00239SlidingWindowMaximum.MonotonicFunction;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MaxSlidingWindowCases), MemberType = typeof(RootSolutionTestCases))]
    public void MaxSlidingWindow_ReturnsMaximumForEachWindow(int[] nums, int k, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.MaxSlidingWindow(nums, k);

        Assert.Equal(expected, actual);
    }
}
