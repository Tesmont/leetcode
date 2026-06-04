namespace LeetCode.P02351FirstLetterToAppearTwice.HashSet;

/// <summary>
/// LeetCode 2351. First Letter to Appear Twice.
/// https://leetcode.com/problems/first-letter-to-appear-twice/
/// </summary>
public sealed class Solution
{
    public char RepeatedCharacter(string s)
    {
        HashSet<char> set = [];
        foreach (char ch in s)
        {
            if (!set.Add(ch))
            {
                return ch;
            }
        }

        throw new InvalidOperationException("No solution found.");
    }
}
