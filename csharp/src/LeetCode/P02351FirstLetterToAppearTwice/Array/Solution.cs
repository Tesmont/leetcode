namespace LeetCode.P02351FirstLetterToAppearTwice.Array;

/// <summary>
/// LeetCode #2351 - First Letter to Appear Twice.
/// Problem: https://leetcode.com/problems/first-letter-to-appear-twice/
/// </summary>
public sealed class Solution
{
    public char RepeatedCharacter(string s)
    {
        Span<bool> seen = stackalloc bool[128];

        foreach (char letter in s)
        {
            if (seen[letter])
            {
                return letter;
            }

            seen[letter] = true;
        }

        throw new System.InvalidOperationException();
    }
}
