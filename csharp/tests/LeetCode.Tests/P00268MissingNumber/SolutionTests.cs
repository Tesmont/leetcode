using LeetCode.P00268MissingNumber;
using Xunit;

namespace LeetCode.Tests.P00268MissingNumber;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.MissingNumberCases), MemberType = typeof(SolutionTestCases))]
    public void MissingNumber_ReturnsMissingNumber(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MissingNumber(nums);

        Assert.Equal(expected, actual);
    }
}
