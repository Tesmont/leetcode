using LeetCode.P01133LargestUniqueNumber;
using Xunit;

namespace LeetCode.Tests.P01133LargestUniqueNumber;

public sealed class SolutionTests
{
    public static TheoryData<int[], int> LargestUniqueNumberCases =>
        new()
        {
            { [5, 7, 3, 9, 4, 9, 8, 3, 1], 8 },
            { [9, 9, 8, 8], -1 },
            { [1], 1 },
        };

    [Theory]
    [MemberData(nameof(LargestUniqueNumberCases))]
    public void LargestUniqueNumber_ReturnsExpectedNumber(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.LargestUniqueNumber(nums);

        Assert.Equal(expected, actual);
    }
}
