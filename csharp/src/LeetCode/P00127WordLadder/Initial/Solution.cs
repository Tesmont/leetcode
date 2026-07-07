using System.Text;

namespace LeetCode.P00127WordLadder.Initial;

/// <summary>
/// LeetCode 127. Word Ladder.
/// https://leetcode.com/problems/word-ladder/
/// </summary>
public sealed class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        const char substitution = '*';

        int wordLength = beginWord.Length;
        Dictionary<string, List<string>> wildcards = new(wordList.Count * wordLength);

        bool exist = false;
        foreach (string word in wordList)
        {
            if (word == endWord)
            {
                exist = true;
            }

            foreach (string pattern in GetPatterns(word))
            {
                if (!wildcards.TryGetValue(pattern, out List<string>? words))
                {
                    words = new List<string>();
                    wildcards.Add(pattern, words);
                }

                words.Add(word);
            }
        }

        if (!exist)
        {
            return 0;
        }

        HashSet<string> seen = new();
        Queue<string> queue = new();

        seen.Add(beginWord);
        queue.Enqueue(beginWord);
        int distance = 1;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++)
            {
                string word = queue.Dequeue();

                foreach (string pattern in GetPatterns(word))
                {
                    if (wildcards.TryGetValue(pattern, out List<string>? neighbors))
                    {
                        foreach (string neighbor in neighbors)
                        {
                            if (!seen.Add(neighbor))
                            {
                                continue;
                            }

                            if (neighbor == endWord)
                            {
                                return distance + 1;
                            }

                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }

            distance++;
        }

        return 0;

        IEnumerable<string> GetPatterns(string word)
        {
            StringBuilder builder = new(word);

            for (int i = 0; i < wordLength; i++)
            {
                builder[i] = substitution;
                yield return builder.ToString();
                builder[i] = word[i];
            }
        }
    }
}
