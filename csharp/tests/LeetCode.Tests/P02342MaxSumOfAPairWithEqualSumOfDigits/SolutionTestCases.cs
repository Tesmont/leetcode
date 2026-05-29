using Xunit;

namespace LeetCode.Tests.P02342MaxSumOfAPairWithEqualSumOfDigits;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> MaximumSumCases =>
        new()
        {
            { [18, 43, 36, 13, 7], 54 },
            { [10, 12, 19, 14], -1 },
        };
}
