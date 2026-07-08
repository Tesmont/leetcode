namespace LeetCode.P01046LastStoneWeight.Initial;

/// <summary>
/// LeetCode 1046. Last Stone Weight.
/// https://leetcode.com/problems/last-stone-weight/
/// </summary>
public sealed class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        PriorityQueue<int, int> queue = new(
            stones.Select(i => (i, i)),
            Comparer<int>.Create((a, b) => b.CompareTo(a)));

        while (queue.Count >= 2)
        {
            int stone1 = queue.Dequeue();
            int stone2 = queue.Dequeue();
            if (stone1 == stone2)
            {
                continue;
            }

            int newStone = stone1 - stone2;
            queue.Enqueue(newStone, newStone);
        }

        return queue.Count == 0
            ? 0
            : queue.Peek();
    }
}
