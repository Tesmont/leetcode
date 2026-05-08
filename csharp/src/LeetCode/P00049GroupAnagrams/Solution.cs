namespace LeetCode.P00049GroupAnagrams;

/// <summary>
/// LeetCode 49. Group Anagrams.
/// https://leetcode.com/problems/group-anagrams/
/// </summary>
public sealed class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        const int firstLowercaseLetter = 'a';
        const int letterCountBufferLength = 'z' + 1;
        
        Dictionary<string, List<string>> groupsDictionary = new(strs.Length);
        List<IList<string>> groups = [];
        Span<char> letterCounts = stackalloc char[letterCountBufferLength];

        for (int i = 0; i < strs.Length; i++)
        {
            string str = strs[i];
            letterCounts.Clear();

            for (int j = 0; j < str.Length; j++)
            {
                letterCounts[str[j]]++;
            }

            string key = new(letterCounts[firstLowercaseLetter..letterCountBufferLength]);
            if (!groupsDictionary.TryGetValue(key, out List<string>? group))
            {
                group = [];
                groups.Add(group);
                groupsDictionary[key] = group;
            }

            group.Add(str);
        }

        return groups;
    }
}
