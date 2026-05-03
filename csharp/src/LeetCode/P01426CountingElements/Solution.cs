namespace LeetCode.P01426CountingElements;

/// <summary>
/// LeetCode 1426. Counting Elements.
/// https://leetcode.com/problems/counting-elements/
/// </summary>
public sealed class Solution
{
    public int CountElements(int[] arr)
    {
        Span<byte> seen = stackalloc byte[1002];
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
