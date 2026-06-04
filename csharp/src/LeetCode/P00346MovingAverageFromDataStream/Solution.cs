namespace LeetCode.P00346MovingAverageFromDataStream;

/// <summary>
/// LeetCode 346. Moving Average from Data Stream.
/// https://leetcode.com/problems/moving-average-from-data-stream/
/// </summary>
public sealed class MovingAverage
{
    private readonly int[] _values;
    private int _count;
    private int _nextIndex;
    private long _sum;

    public MovingAverage(int size)
    {
        _values = new int[size];
    }

    public double Next(int val)
    {
        if (_count < _values.Length)
        {
            _count++;
        }
        else
        {
            _sum -= _values[_nextIndex];
        }

        _values[_nextIndex] = val;
        _sum += val;
        _nextIndex = (_nextIndex + 1) % _values.Length;

        return (double)_sum / _count;
    }
}
