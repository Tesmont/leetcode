using LeetCode.P03005CountElementsWithMaximumFrequency.Counting;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P03005CountElementsWithMaximumFrequency.SolutionTestCases;

namespace LeetCode.Tests.P03005CountElementsWithMaximumFrequency.Counting;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MaxFrequencyElementsCases), MemberType = typeof(RootSolutionTestCases))]
    public void MaxFrequencyElements_ReturnsTotalFrequenciesOfElementsWithMaximumFrequency(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxFrequencyElements(nums);

        Assert.Equal(expected, actual);
    }
}
