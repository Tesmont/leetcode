using LeetCode.P01748SumOfUniqueElements.Counting;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01748SumOfUniqueElements.SolutionTestCases;

namespace LeetCode.Tests.P01748SumOfUniqueElements.Counting;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.SumOfUniqueCases), MemberType = typeof(RootSolutionTestCases))]
    public void SumOfUnique_ReturnsSumOfElementsThatAppearExactlyOnce(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.SumOfUnique(nums);

        Assert.Equal(expected, actual);
    }
}
