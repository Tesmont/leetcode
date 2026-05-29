using LeetCode.P02540MinimumCommonValue;
using Xunit;

namespace LeetCode.Tests.P02540MinimumCommonValue;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.GetCommonCases), MemberType = typeof(SolutionTestCases))]
    public void GetCommon_ReturnsMinimumCommonValue(int[] nums1, int[] nums2, int expected)
    {
        Solution solution = new();

        int actual = solution.GetCommon(nums1, nums2);

        Assert.Equal(expected, actual);
    }
}
