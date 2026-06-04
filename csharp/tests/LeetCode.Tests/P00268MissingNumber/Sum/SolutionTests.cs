using LeetCode.P00268MissingNumber.Sum;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00268MissingNumber.SolutionTestCases;

namespace LeetCode.Tests.P00268MissingNumber.Sum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MissingNumberCases), MemberType = typeof(RootSolutionTestCases))]
    public void MissingNumber_ReturnsMissingNumber(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MissingNumber(nums);

        Assert.Equal(expected, actual);
    }
}
