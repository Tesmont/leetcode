using LeetCode.P01063NumberOfValidSubarrays.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01063NumberOfValidSubarrays.SolutionTestCases;

namespace LeetCode.Tests.P01063NumberOfValidSubarrays.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.ValidSubarraysCases), MemberType = typeof(RootSolutionTestCases))]
    public void ValidSubarrays_ReturnsNumberOfValidSubarrays(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.ValidSubarrays(nums);

        Assert.Equal(expected, actual);
    }
}
