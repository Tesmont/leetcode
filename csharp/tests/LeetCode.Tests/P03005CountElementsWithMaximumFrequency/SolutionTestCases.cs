using Xunit;

namespace LeetCode.Tests.P03005CountElementsWithMaximumFrequency;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> MaxFrequencyElementsCases =>
        new()
        {
            { [1, 2, 2, 3, 1, 4], 4 },
            { [1, 2, 3, 4, 5], 5 },
        };
}
