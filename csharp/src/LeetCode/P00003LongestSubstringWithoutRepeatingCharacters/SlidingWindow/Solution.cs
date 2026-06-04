namespace LeetCode.P00003LongestSubstringWithoutRepeatingCharacters.SlidingWindow;

/// <summary>
/// LeetCode 3. Longest Substring Without Repeating Characters.
/// https://leetcode.com/problems/longest-substring-without-repeating-characters/
/// </summary>
public sealed class Solution
{
    public int LengthOfLongestSubstring(string text)
    {
        const int asciiCharacterCount = 128;

        Span<bool> charactersInWindow = stackalloc bool[asciiCharacterCount];
        int leftIndex = 0;
        int maxSubstringLength = 0;

        for (int rightIndex = 0; rightIndex < text.Length; rightIndex++)
        {
            int rightCharacter = text[rightIndex];

            while (charactersInWindow[rightCharacter])
            {
                charactersInWindow[text[leftIndex]] = false;
                leftIndex++;
            }

            charactersInWindow[rightCharacter] = true;
            maxSubstringLength = Math.Max(maxSubstringLength, rightIndex - leftIndex + 1);
        }

        return maxSubstringLength;
    }
}
