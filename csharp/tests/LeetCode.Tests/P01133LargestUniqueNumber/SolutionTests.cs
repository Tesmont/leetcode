using LeetCode.P01133LargestUniqueNumber;
using Xunit;

namespace LeetCode.Tests.P01133LargestUniqueNumber;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.LargestUniqueNumberCases), MemberType = typeof(SolutionTestCases))]
    public void LargestUniqueNumber_ReturnsExpectedNumber(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.LargestUniqueNumber(nums);

        Assert.Equal(expected, actual);
    }
}
