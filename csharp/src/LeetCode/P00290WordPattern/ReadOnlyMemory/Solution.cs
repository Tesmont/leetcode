namespace LeetCode.P00290WordPattern.ReadOnlyMemory;

/// <summary>
/// LeetCode 290. Word Pattern.
/// https://leetcode.com/problems/word-pattern/
/// </summary>
public sealed class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        const char wordSeparator = ' ';
        Dictionary<char, ReadOnlyMemory<char>> patternMap = new(pattern.Length);
        Dictionary<ReadOnlyMemory<char>, char> wordMap = new(pattern.Length, ReadOnlyMemoryCharComparer.Ordinal);

        ReadOnlyMemory<char> sMemory = s.AsMemory();
        for (int i = 0; i < pattern.Length; i++)
        {
            if (sMemory.Length == 0)
            {
                return false;
            }

            char ch = pattern[i];
            int separatorIndex = sMemory.Span.IndexOf(wordSeparator);
            ReadOnlyMemory<char> word = separatorIndex < 0
                ? sMemory
                : sMemory[..separatorIndex];

            if (!patternMap.TryAdd(ch, word))
            {
                ReadOnlyMemory<char> expectedWord = patternMap[ch];
                if (!expectedWord.Span.SequenceEqual(word.Span))
                {
                    return false;
                }
            }

            if (!wordMap.TryAdd(word, ch))
            {
                char expectedCh = wordMap[word];
                if (expectedCh != ch)
                {
                    return false;
                }
            }

            sMemory = separatorIndex < 0
                ? ReadOnlyMemory<char>.Empty
                : sMemory[(separatorIndex + 1)..];
        }

        if (sMemory.Length != 0)
        {
            return false;
        }

        return true;
    }

    private sealed class ReadOnlyMemoryCharComparer : IEqualityComparer<ReadOnlyMemory<char>>
    {
        public static readonly ReadOnlyMemoryCharComparer Ordinal = new();

        public bool Equals(ReadOnlyMemory<char> x, ReadOnlyMemory<char> y)
        {
            return x.Span.SequenceEqual(y.Span);
        }

        public int GetHashCode(ReadOnlyMemory<char> obj)
        {
            HashCode hashCode = new();
            foreach (char ch in obj.Span)
            {
                hashCode.Add(ch);
            }

            return hashCode.ToHashCode();
        }
    }
}
