using LeetCode.P02540MinimumCommonValue.TwoPointers;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02540MinimumCommonValue.SolutionTestCases;

namespace LeetCode.Tests.P02540MinimumCommonValue.TwoPointers;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.GetCommonCases), MemberType = typeof(RootSolutionTestCases))]
    public void GetCommon_ReturnsMinimumCommonValue(int[] nums1, int[] nums2, int expected)
    {
        Solution solution = new();

        int actual = solution.GetCommon(nums1, nums2);

        Assert.Equal(expected, actual);
    }
}
