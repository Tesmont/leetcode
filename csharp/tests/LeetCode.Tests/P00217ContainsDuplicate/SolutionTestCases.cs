using Xunit;

namespace LeetCode.Tests.P00217ContainsDuplicate;

public static class SolutionTestCases
{
    public static TheoryData<int[], bool> ContainsDuplicateCases =>
        new()
        {
            { [1, 2, 3, 1], true },
            { [1, 2, 3, 4], false },
            { [1, 1, 1, 3, 3, 4, 3, 2, 4, 2], true },
        };
}
