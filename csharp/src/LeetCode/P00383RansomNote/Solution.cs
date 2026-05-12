namespace LeetCode.P00383RansomNote;

/// <summary>
/// LeetCode 383. Ransom Note.
/// https://leetcode.com/problems/ransom-note/
/// </summary>
public sealed class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        const int lastLowercaseLetter = 'z';

        Span<int> counts = stackalloc int[lastLowercaseLetter + 1];
        for (int i = 0; i < magazine.Length; i++)
        {
            counts[magazine[i]]++;
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            counts[ransomNote[i]]--;
            if (counts[ransomNote[i]] < 0)
            {
                return false;
            }
        }

        return true;
    }
}
