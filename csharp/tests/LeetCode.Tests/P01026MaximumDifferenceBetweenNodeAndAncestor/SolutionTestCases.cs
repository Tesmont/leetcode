using Xunit;

namespace LeetCode.Tests.P01026MaximumDifferenceBetweenNodeAndAncestor;

public static class SolutionTestCases
{
    public static TheoryData<int?[], int> MaxAncestorDiffCases =>
        new()
        {
            { [8, 3, 10, 1, 6, null, 14, null, null, 4, 7, 13], 7 },
            { [1, null, 2, null, 0, 3], 3 },
            { [5, 3], 2 },
        };
}
