using LeetCode.P02090KRadiusSubarrayAverages;
using Xunit;

namespace LeetCode.Tests.P02090KRadiusSubarrayAverages;

public sealed class SolutionTests
{
    public static TheoryData<int[], int, int[]> GetAveragesCases =>
        new()
        {
            { [7, 4, 3, 9, 1, 8, 5, 2, 6], 3, [-1, -1, -1, 5, 4, 4, -1, -1, -1] },
            { [100000], 0, [100000] },
            { [8], 100000, [-1] },
        };

    [Theory]
    [MemberData(nameof(GetAveragesCases))]
    public void GetAverages_ReturnsExpectedValues(int[] nums, int k, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.GetAverages(nums, k);

        Assert.Equal(expected, actual);
    }
}
