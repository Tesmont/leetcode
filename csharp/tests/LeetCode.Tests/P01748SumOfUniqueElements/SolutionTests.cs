using LeetCode.P01748SumOfUniqueElements;
using Xunit;

namespace LeetCode.Tests.P01748SumOfUniqueElements;

public sealed class SolutionTests
{
    public static TheoryData<int[], int> SumOfUniqueCases =>
        new()
        {
            { [1, 2, 3, 2], 4 },
            { [1, 1, 1, 1, 1], 0 },
            { [1, 2, 3, 4, 5], 15 },
        };

    [Theory]
    [MemberData(nameof(SumOfUniqueCases))]
    public void SumOfUnique_ReturnsSumOfElementsThatAppearExactlyOnce(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.SumOfUnique(nums);

        Assert.Equal(expected, actual);
    }
}
