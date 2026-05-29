using LeetCode.P02260MinimumConsecutiveCardsToPickUp;
using Xunit;

namespace LeetCode.Tests.P02260MinimumConsecutiveCardsToPickUp;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.MinimumCardPickupCases), MemberType = typeof(SolutionTestCases))]
    public void MinimumCardPickup_ReturnsMinimumConsecutiveCards(int[] cards, int expected)
    {
        Solution solution = new();

        int actual = solution.MinimumCardPickup(cards);

        Assert.Equal(expected, actual);
    }
}
