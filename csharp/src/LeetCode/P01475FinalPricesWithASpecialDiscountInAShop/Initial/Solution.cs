namespace LeetCode.P01475FinalPricesWithASpecialDiscountInAShop.Initial;

/// <summary>
/// LeetCode 1475. Final Prices With a Special Discount in a Shop.
/// https://leetcode.com/problems/final-prices-with-a-special-discount-in-a-shop/
/// </summary>
public sealed class Solution
{
    public int[] FinalPrices(int[] prices)
    {
        Span<int> discounts = stackalloc int[prices.Length];
        int stackCount = 0;

        for (int i = prices.Length - 1; i >= 0; i--)
        {
            int price = prices[i];

            while (stackCount > 0 && discounts[stackCount - 1] > price)
            {
                stackCount--;
            }

            int discount = stackCount > 0
                ? discounts[stackCount - 1]
                : 0;

            prices[i] = price - discount;
            discounts[stackCount] = price;
            stackCount++;
        }

        return prices;
    }
}
