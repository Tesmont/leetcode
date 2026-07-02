namespace LeetCode.P00752OpenTheLock.Initial;

/// <summary>
/// LeetCode 752. Open the Lock.
/// https://leetcode.com/problems/open-the-lock/
/// </summary>
public sealed class Solution
{
    private static readonly int[] UpDelta = [1, 1, 1, 1, 1, 1, 1, 1, 1, -9];
    private static readonly int[] DownDelta = [9, -1, -1, -1, -1, -1, -1, -1, -1, -1];

    public int OpenLock(string[] deadends, string target)
    {
        const int stateCount = 10 * 10 * 10 * 10;
        const int startState = 0;
        int targetState = int.Parse(target);

        Span<bool> seen = stackalloc bool[stateCount];
        foreach (string deadend in deadends)
        {
            seen[int.Parse(deadend)] = true;
        }

        if (seen[startState] || seen[targetState])
        {
            return -1;
        }

        if (startState == targetState)
        {
            return 0;
        }

        Queue<int> queue = new();

        seen[startState] = true;
        queue.Enqueue(startState);

        int distance = 0;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++)
            {
                int state = queue.Dequeue();

                for (int placeValue = 1; placeValue <= 1000; placeValue *= 10)
                {
                    int digit = state / placeValue % 10;

                    int upState = state + UpDelta[digit] * placeValue;
                    int downState = state + DownDelta[digit] * placeValue;

                    if (targetState == upState
                        || targetState == downState)
                    {
                        return distance + 1;
                    }

                    if (!seen[upState])
                    {
                        seen[upState] = true;
                        queue.Enqueue(upState);
                    }

                    if (!seen[downState])
                    {
                        seen[downState] = true;
                        queue.Enqueue(downState);
                    }
                }

            }

            distance++;
        }

        return -1;
    }
}
