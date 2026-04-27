namespace LeetCode.P00344ReverseString;

/// <summary>
/// LeetCode #344 - Reverse String.
/// Problem: https://leetcode.com/problems/reverse-string/
/// </summary>
public sealed class Solution
{
    public void ReverseString(char[] s)
    {
        int leftIndex = 0;
        int rightIndex = s.Length - 1;
        
        while (leftIndex < rightIndex)
        {
            char buf = s[leftIndex];
            s[leftIndex] = s[rightIndex];
            s[rightIndex] = buf;

            leftIndex++;
            rightIndex--;
        }
    }
}
