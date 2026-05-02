using LeetCode.P02540MinimumCommonValue;
using Xunit;

namespace LeetCode.Tests.P02540MinimumCommonValue;

public sealed class SolutionTests
{
    public static TheoryData<int[], int[], int> GetCommonCases =>
        new()
        {
            { [1, 2, 3], [2, 4], 2 },
            { [1, 2, 3, 6], [2, 3, 4, 5], 2 },
            { [1, 3, 5], [2, 4, 6], -1 },
        };

    [Theory]
    [MemberData(nameof(GetCommonCases))]
    public void GetCommon_ReturnsMinimumCommonValue(int[] nums1, int[] nums2, int expected)
    {
        Solution solution = new();

        int actual = solution.GetCommon(nums1, nums2);

        Assert.Equal(expected, actual);
    }
}
