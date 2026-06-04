namespace LeetCode.P00933NumberOfRecentCalls.Queue;

/// <summary>
/// LeetCode 933. Number of Recent Calls.
/// https://leetcode.com/problems/number-of-recent-calls/
/// </summary>
public sealed class RecentCounter
{
    const int MaxCallCount = 10_000;
    const int TimeDifference = 3000;

    private readonly int[] _times = new int[MaxCallCount];
    private int _start;
    private int _end;

    public RecentCounter()
    {
    }

    public int Ping(int t)
    {
        _times[_end++] = t;
        int startTime = t - TimeDifference;

        while (_times[_start] < startTime)
        {
            _start++;
        }

        return _end - _start;
    }
}
