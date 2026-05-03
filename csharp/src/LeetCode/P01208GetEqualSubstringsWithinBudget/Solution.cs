namespace LeetCode.P01208GetEqualSubstringsWithinBudget;

/// <summary>
/// LeetCode #1208 - Get Equal Substrings Within Budget.
/// Problem: https://leetcode.com/problems/get-equal-substrings-within-budget/
/// </summary>
public sealed class Solution
{
    public int EqualSubstring(string s, string t, int maxCost)
    {
        int leftIndex = 0;
        int windowCost = 0;
        int maxWindowLength = 0;

        for (int rightIndex = 0; rightIndex < s.Length; rightIndex++)
        {
            windowCost += Math.Abs(s[rightIndex] - t[rightIndex]);

            while (windowCost > maxCost
                && leftIndex <= rightIndex)
            {
                windowCost -= Math.Abs(s[leftIndex] - t[leftIndex]);
                leftIndex++;
            }

            maxWindowLength = Math.Max(maxWindowLength, rightIndex - leftIndex + 1);
        }

        return maxWindowLength;
    }
}
