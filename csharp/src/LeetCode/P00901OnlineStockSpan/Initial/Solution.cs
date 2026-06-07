namespace LeetCode.P00901OnlineStockSpan.Initial;

/// <summary>
/// LeetCode 901. Online Stock Span.
/// https://leetcode.com/problems/online-stock-span/
/// </summary>
public sealed class StockSpanner
{
    private readonly record struct Stock(int Price, int Span);

    private const int MaxDayCount = 10_000;
    private readonly Stack<Stock> _stack = new(MaxDayCount);

    public int Next(int price)
    {
        int span = 1;

        while (_stack.TryPeek(out Stock stock)
            && stock.Price <= price)
        {
            span += stock.Span;
            _stack.Pop();
        }

        _stack.Push(new(price, span));

        return span;
    }
}
