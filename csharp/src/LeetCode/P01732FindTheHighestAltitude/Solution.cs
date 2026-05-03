namespace LeetCode.P01732FindTheHighestAltitude;

/// <summary>
/// LeetCode #1732 - Find the Highest Altitude.
/// Problem: https://leetcode.com/problems/find-the-highest-altitude/
/// </summary>
public sealed class Solution
{
    public int LargestAltitude(int[] gain)
    {
        int maxAltitude = 0;
        int altitude = 0;
        for (int i = 0; i < gain.Length; i++)
        {
            altitude += gain[i];
            maxAltitude = Math.Max(maxAltitude, altitude);
        }

        return maxAltitude;
    }
}
