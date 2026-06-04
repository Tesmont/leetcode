using LeetCode.P01133LargestUniqueNumber.Counting;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01133LargestUniqueNumber.SolutionTestCases;

namespace LeetCode.Tests.P01133LargestUniqueNumber.Counting;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.LargestUniqueNumberCases), MemberType = typeof(RootSolutionTestCases))]
    public void LargestUniqueNumber_ReturnsExpectedNumber(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.LargestUniqueNumber(nums);

        Assert.Equal(expected, actual);
    }
}
