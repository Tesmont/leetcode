using LeetCode.P03005CountElementsWithMaximumFrequency;
using Xunit;

namespace LeetCode.Tests.P03005CountElementsWithMaximumFrequency;

public sealed class SolutionTests
{
    public static TheoryData<int[], int> MaxFrequencyElementsCases =>
        new()
        {
            { [1, 2, 2, 3, 1, 4], 4 },
            { [1, 2, 3, 4, 5], 5 },
        };

    [Theory]
    [MemberData(nameof(MaxFrequencyElementsCases))]
    public void MaxFrequencyElements_ReturnsTotalFrequenciesOfElementsWithMaximumFrequency(int[] nums, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxFrequencyElements(nums);

        Assert.Equal(expected, actual);
    }
}
