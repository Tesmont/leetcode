namespace LeetCode.P02260MinimumConsecutiveCardsToPickUp;

/// <summary>
/// LeetCode 2260. Minimum Consecutive Cards to Pick Up.
/// https://leetcode.com/problems/minimum-consecutive-cards-to-pick-up/
/// </summary>
public sealed class Solution
{
    public int MinimumCardPickup(int[] cards)
    {
        Dictionary<int, int> lastSeenIndices = new(cards.Length);
        int minPickupLength = int.MaxValue;

        for (int i = 0; i < cards.Length; i++)
        {
            int card = cards[i];

            if (lastSeenIndices.TryGetValue(card, out int previousIndex))
            {
                int pickupLength = i - previousIndex + 1;
                minPickupLength = Math.Min(minPickupLength, pickupLength);
            }

            lastSeenIndices[card] = i;
        }

        return minPickupLength == int.MaxValue
            ? -1
            : minPickupLength;
    }
}
