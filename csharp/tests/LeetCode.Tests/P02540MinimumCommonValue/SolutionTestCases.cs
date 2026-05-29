using Xunit;

namespace LeetCode.Tests.P02540MinimumCommonValue;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[], int> GetCommonCases =>
        new()
        {
            { [1, 2, 3], [2, 4], 2 },
            { [1, 2, 3, 6], [2, 3, 4, 5], 2 },
            { [1, 3, 5], [2, 4, 6], -1 },
        };
}
