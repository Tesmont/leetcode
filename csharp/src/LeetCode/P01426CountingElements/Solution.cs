namespace LeetCode.P01426CountingElements;

/// <summary>
/// LeetCode 1426. Counting Elements.
/// https://leetcode.com/problems/counting-elements/
/// </summary>
public sealed class Solution
{
    public int CountElements(int[] arr)
    {
        const int maxValue = 1_000;
        const int seenSize = maxValue + 2;

        Span<byte> seen = stackalloc byte[seenSize];
        foreach (int num in arr)
        {
            seen[num] = 1;
        }

        int count = 0;
        foreach (int num in arr)
        {
            count += seen[num + 1];
        }

        return count;
    }
}
