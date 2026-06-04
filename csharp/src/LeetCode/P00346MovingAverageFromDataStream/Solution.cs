namespace LeetCode.P00346MovingAverageFromDataStream;

/// <summary>
/// LeetCode 346. Moving Average from Data Stream.
/// https://leetcode.com/problems/moving-average-from-data-stream/
/// </summary>
public sealed class MovingAverage
{
    const int MaxLength = 10_000;
    private readonly Queue<int> _queue = new(MaxLength);
    private readonly int _windowLength;
    private int _windowTotal = 0;

    public MovingAverage(int size)
    {
        _windowLength = size;
    }

    public double Next(int val)
    {
        _queue.Enqueue(val);
        _windowTotal += val;

        if (_queue.Count > _windowLength)
        {
            _windowTotal -= _queue.Dequeue();
        }

        return (double)_windowTotal / _queue.Count;
    }
}
