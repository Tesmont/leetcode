using Xunit;

namespace LeetCode.Tests.P01732FindTheHighestAltitude;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> LargestAltitudeCases =>
        new()
        {
            { [-5, 1, 5, 0, -7], 1 },
            { [-4, -3, -2, -1, 4, 3, 2], 0 },
        };
}
