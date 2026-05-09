using LeetCode.P02260MinimumConsecutiveCardsToPickUp;
using Xunit;

namespace LeetCode.Tests.P02260MinimumConsecutiveCardsToPickUp;

public sealed class SolutionTests
{
    public static TheoryData<int[], int> MinimumCardPickupCases =>
        new()
        {
            { [3, 4, 2, 3, 4, 7], 4 },
            { [1, 0, 5, 3], -1 },
            { [7, 7], 2 },
            { [1, 2, 3, 1, 2, 3], 4 },
        };

    [Theory]
    [MemberData(nameof(MinimumCardPickupCases))]
    public void MinimumCardPickup_ReturnsMinimumConsecutiveCards(int[] cards, int expected)
    {
        Solution solution = new();

        int actual = solution.MinimumCardPickup(cards);

        Assert.Equal(expected, actual);
    }
}
