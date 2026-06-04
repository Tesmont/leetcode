using LeetCode.P02260MinimumConsecutiveCardsToPickUp.HashMap;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02260MinimumConsecutiveCardsToPickUp.SolutionTestCases;

namespace LeetCode.Tests.P02260MinimumConsecutiveCardsToPickUp.HashMap;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MinimumCardPickupCases), MemberType = typeof(RootSolutionTestCases))]
    public void MinimumCardPickup_ReturnsMinimumConsecutiveCards(int[] cards, int expected)
    {
        Solution solution = new();

        int actual = solution.MinimumCardPickup(cards);

        Assert.Equal(expected, actual);
    }
}
