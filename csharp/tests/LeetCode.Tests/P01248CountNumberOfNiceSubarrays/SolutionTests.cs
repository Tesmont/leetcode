using LeetCode.P01248CountNumberOfNiceSubarrays;
using Xunit;

namespace LeetCode.Tests.P01248CountNumberOfNiceSubarrays;

public sealed class SolutionTests
{
    public static TheoryData<int[], int, int> NumberOfSubarraysCases =>
        new()
        {
            { [1, 1, 2, 1, 1], 3, 2 },
            { [2, 4, 6], 1, 0 },
            { [2, 2, 2, 1, 2, 2, 1, 2, 2, 2], 2, 16 },
        };

    [Theory]
    [MemberData(nameof(NumberOfSubarraysCases))]
    public void NumberOfSubarrays_ReturnsNiceSubarrayCount(int[] nums, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.NumberOfSubarrays(nums, k);

        Assert.Equal(expected, actual);
    }
}
