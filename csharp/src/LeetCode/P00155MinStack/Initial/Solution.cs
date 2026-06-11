namespace LeetCode.P00155MinStack.Initial;

/// <summary>
/// LeetCode 155. Min Stack.
/// https://leetcode.com/problems/min-stack/
/// </summary>
public sealed class MinStack
{
    const int MaxCallCount = 30_000;
    private readonly Stack<(int Val, int MinVal)> _stack = new(MaxCallCount);

    public void Push(int val)
    {
        int min = _stack.Count == 0
            ? val
            : Math.Min(val, _stack.Peek().MinVal);
        _stack.Push((val, min));
    }

    public void Pop()
    {
        _stack.Pop();
    }

    public int Top()
    {
        return _stack.Peek().Val;
    }

    public int GetMin()
    {
        return _stack.Peek().MinVal;
    }
}
