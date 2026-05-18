using LeetCode.P01695MaximumErasureValue;
using Xunit;

namespace LeetCode.Tests.P01695MaximumErasureValue;

public sealed class SolutionTests
{
    public static TheoryData<int[], int> MaximumUniqueSubarrayCases =>
        new()
        {
            { [4, 2, 4, 5, 6], 17 },
            { [5, 2, 1, 2, 5, 2, 1, 2, 5], 8 },
            { [10000], 10000 },
        };

    [Theory]
    [MemberData(nameof(MaximumUniqueSubarrayCases))]
    public void MaximumUniqueSubarray_ReturnsMaximumSumOfUniqueSubarray(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MaximumUniqueSubarray(nums);

        Assert.Equal(expected, actual);
    }
}
