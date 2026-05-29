using LeetCode.P01748SumOfUniqueElements;
using Xunit;

namespace LeetCode.Tests.P01748SumOfUniqueElements;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.SumOfUniqueCases), MemberType = typeof(SolutionTestCases))]
    public void SumOfUnique_ReturnsSumOfElementsThatAppearExactlyOnce(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.SumOfUnique(nums);

        Assert.Equal(expected, actual);
    }
}
