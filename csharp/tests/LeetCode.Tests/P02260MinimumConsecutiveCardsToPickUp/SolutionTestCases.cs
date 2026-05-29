using Xunit;

namespace LeetCode.Tests.P02260MinimumConsecutiveCardsToPickUp;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> MinimumCardPickupCases =>
        new()
        {
            { [3, 4, 2, 3, 4, 7], 4 },
            { [1, 0, 5, 3], -1 },
            { [7, 7], 2 },
            { [1, 2, 3, 1, 2, 3], 4 },
        };
}
