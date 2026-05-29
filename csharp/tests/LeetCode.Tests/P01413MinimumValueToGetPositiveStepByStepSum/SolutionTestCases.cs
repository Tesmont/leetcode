using Xunit;

namespace LeetCode.Tests.P01413MinimumValueToGetPositiveStepByStepSum;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> MinStartValueCases =>
        new()
        {
            { [-3, 2, -3, 4, 2], 5 },
            { [1, 2], 1 },
            { [1, -2, -3], 5 },
        };
}
