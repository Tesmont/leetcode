namespace LeetCode.P00225ImplementStackUsingQueues.Initial;

/// <summary>
/// LeetCode 225. Implement Stack using Queues.
/// https://leetcode.com/problems/implement-stack-using-queues/
/// </summary>
public sealed class MyStack
{
    private readonly Queue<int> _queue = new();

    public void Push(int x)
    {
        _queue.Enqueue(x);

        for (int i = 1; i < _queue.Count; i++)
        {
            _queue.Enqueue(_queue.Dequeue());
        }
    }

    public int Pop()
    {
        return _queue.Dequeue();
    }

    public int Top()
    {
        return _queue.Peek();
    }

    public bool Empty()
    {
        return _queue.Count == 0;
    }
}
