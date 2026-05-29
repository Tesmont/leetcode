using LeetCode.P03005CountElementsWithMaximumFrequency;
using Xunit;

namespace LeetCode.Tests.P03005CountElementsWithMaximumFrequency;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.MaxFrequencyElementsCases), MemberType = typeof(SolutionTestCases))]
    public void MaxFrequencyElements_ReturnsTotalFrequenciesOfElementsWithMaximumFrequency(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxFrequencyElements(nums);

        Assert.Equal(expected, actual);
    }
}
