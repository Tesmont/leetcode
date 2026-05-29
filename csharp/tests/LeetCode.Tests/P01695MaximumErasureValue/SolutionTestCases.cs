using Xunit;

namespace LeetCode.Tests.P01695MaximumErasureValue;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> MaximumUniqueSubarrayCases =>
        new()
        {
            { [4, 2, 4, 5, 6], 17 },
            { [5, 2, 1, 2, 5, 2, 1, 2, 5], 8 },
            { [10000], 10000 },
        };
}
