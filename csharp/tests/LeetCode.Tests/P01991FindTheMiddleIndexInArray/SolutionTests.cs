using LeetCode.P01991FindTheMiddleIndexInArray;
using Xunit;

namespace LeetCode.Tests.P01991FindTheMiddleIndexInArray;

public sealed class SolutionTests
{
    public static TheoryData<int[], int> FindMiddleIndexCases =>
        new()
        {
            { [2, 3, -1, 8, 4], 3 },
            { [1, -1, 4], 2 },
            { [2, 5], -1 },
        };

    [Theory]
    [MemberData(nameof(FindMiddleIndexCases))]
    public void FindMiddleIndex_ReturnsExpectedIndex(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.FindMiddleIndex(nums);

        Assert.Equal(expected, actual);
    }
}
