namespace LeetCode.P00290WordPattern;

/// <summary>
/// LeetCode 290. Word Pattern.
/// https://leetcode.com/problems/word-pattern/
/// </summary>
public sealed class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        const char wordSeparator = ' ';
        string[] words = s.Split(wordSeparator);
        if (pattern.Length != words.Length)
        {
            return false;
        }

        Dictionary<char, string> patternMap = new(pattern.Length);
        HashSet<string> wordSet = new(pattern.Length, StringComparer.Ordinal);

        for (int i = 0; i < pattern.Length; i++)
        {
            char ch = pattern[i];
            string word = words[i];

            if (!patternMap.TryAdd(ch, word))
            {
                if (patternMap[ch] != word)
                {
                    return false;
                }
            }
            else
            {
                if (wordSet.Contains(word))
                {
                    return false;
                }

                patternMap[ch] = word;
                wordSet.Add(word);
            }
        }

        return true;
    }
}
