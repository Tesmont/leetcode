namespace LeetCode.P00771JewelsAndStones;

/// <summary>
/// LeetCode 771. Jewels and Stones.
/// https://leetcode.com/problems/jewels-and-stones/
/// </summary>
public sealed class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        const int asciiLookupSize = 'z' + 1;

        Span<byte> jewelCountsByCharacter = stackalloc byte[asciiLookupSize];
        for (int i = 0; i < jewels.Length; i++)
        {
            jewelCountsByCharacter[jewels[i]]++;
        }

        int jewelStoneCount = 0;
        for (int i = 0; i < stones.Length; i++)
        {
            jewelStoneCount += jewelCountsByCharacter[stones[i]];
        }

        return jewelStoneCount;
    }
}
