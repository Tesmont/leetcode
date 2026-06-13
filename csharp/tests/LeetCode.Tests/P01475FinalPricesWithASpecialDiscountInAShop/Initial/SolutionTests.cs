using LeetCode.P01475FinalPricesWithASpecialDiscountInAShop.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01475FinalPricesWithASpecialDiscountInAShop.SolutionTestCases;

namespace LeetCode.Tests.P01475FinalPricesWithASpecialDiscountInAShop.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.FinalPricesCases), MemberType = typeof(RootSolutionTestCases))]
    public void FinalPrices_ReturnsPricesAfterSpecialDiscount(int[] prices, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.FinalPrices(prices);

        Assert.Equal(expected, actual);
    }
}
