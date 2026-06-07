namespace LeetCode.P02390RemovingStarsFromAString.Initial;

/// <summary>
/// LeetCode 2390. Removing Stars From a String.
/// https://leetcode.com/problems/removing-stars-from-a-string/
/// </summary>
public sealed class Solution
{
    public string RemoveStars(string s)
    {
        const char star = '*';

        Span<char> buffer = stackalloc char[s.Length];
        int bufferIndex = buffer.Length - 1;
        int starCount = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == star)
            {
                starCount++;
                continue;
            }

            if (starCount > 0)
            {
                starCount--;
                continue;
            }

            buffer[bufferIndex] = s[i];
            bufferIndex--;
        }

        return new string(buffer[(bufferIndex + 1)..]);
    }
}
