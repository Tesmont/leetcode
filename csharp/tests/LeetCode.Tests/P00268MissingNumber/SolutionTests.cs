using LeetCode.P00268MissingNumber;
using Xunit;

namespace LeetCode.Tests.P00268MissingNumber;

public sealed class SolutionTests
{
    public static TheoryData<int[], int> MissingNumberCases =>
        new()
        {
            { [3, 0, 1], 2 },
            { [0, 1], 2 },
            { [9, 6, 4, 2, 3, 5, 7, 0, 1], 8 },
        };

    [Theory]
    [MemberData(nameof(MissingNumberCases))]
    public void MissingNumber_ReturnsMissingNumber(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MissingNumber(nums);

        Assert.Equal(expected, actual);
    }
}
