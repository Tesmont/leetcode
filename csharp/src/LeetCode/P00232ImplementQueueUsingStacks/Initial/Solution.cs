namespace LeetCode.P00232ImplementQueueUsingStacks.Initial;

/// <summary>
/// LeetCode 232. Implement Queue using Stacks.
/// https://leetcode.com/problems/implement-queue-using-stacks/
/// </summary>
public sealed class MyQueue
{
    private const int MaxStackCount = 100;
    private readonly Stack<int> _inputStack = new(MaxStackCount);
    private readonly Stack<int> _outputStack = new(MaxStackCount);

    private void MoveToOutputIfNeeded()
    {
        if (_outputStack.Count > 0)
        {
            return;
        }

        while (_inputStack.TryPop(out int value))
        {
            _outputStack.Push(value);
        }
    }

    public void Push(int x)
    {
        _inputStack.Push(x);
    }

    public int Pop()
    {
        MoveToOutputIfNeeded();

        return _outputStack.Pop();
    }

    public int Peek()
    {
        MoveToOutputIfNeeded();

        return _outputStack.Peek();
    }

    public bool Empty()
    {
        return _inputStack.Count == 0 && _outputStack.Count == 0;
    }
}
