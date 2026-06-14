using Xunit;

namespace LeetCode.Tests.P01944NumberOfVisiblePeopleInAQueue;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> CanSeePersonsCountCases =>
        new()
        {
            { [10, 6, 8, 5, 11, 9], [3, 1, 2, 1, 1, 0] },
            { [5, 1, 2, 3, 10], [4, 1, 1, 1, 0] },
            { [1], [0] },
            { [1, 2, 3, 4], [1, 1, 1, 0] },
            { [3, 1, 2], [2, 1, 0] },
        };
}
