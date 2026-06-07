using LeetCode.P00901OnlineStockSpan.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00901OnlineStockSpan.SolutionTestCases;

namespace LeetCode.Tests.P00901OnlineStockSpan.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.OnlineStockSpanCases), MemberType = typeof(RootSolutionTestCases))]
    public void Next_ReturnsStockSpanForEachPrice(int[] prices, int[] expected)
    {
        StockSpanner stockSpanner = new();
        int[] actual = new int[prices.Length];

        for (int i = 0; i < prices.Length; i++)
        {
            actual[i] = stockSpanner.Next(prices[i]);
        }

        Assert.Equal(expected, actual);
    }
}
