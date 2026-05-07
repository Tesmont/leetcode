namespace LeetCode.P01861RotatingTheBox;

/// <summary>
/// LeetCode 1861. Rotating the Box.
/// https://leetcode.com/problems/rotating-the-box/
/// </summary>
public sealed class Solution
{
    public char[][] RotateTheBox(char[][] box)
    {
        const char stone = '#';
        const char obstacle = '*';
        const char empty = '.';

        int m = box.Length;
        int n = box[0].Length;
        char[][] result = new char[n][];

        for (int row = 0; row < n; row++)
        {
            result[row] = new char[m];

            for (int column = 0; column < m; column++)
            {
                result[row][column] = empty;
            }
        }

        for (int mIndex = 0; mIndex < m; mIndex++)
        {
            int nextStoneIndex = n - 1;
            for (int nIndex = nextStoneIndex; nIndex >= 0; nIndex--)
            {
                int rotatedColumn = m - 1 - mIndex;
                char current = box[mIndex][nIndex];

                if (current == obstacle)
                {
                    result[nIndex][rotatedColumn] = obstacle;
                    nextStoneIndex = nIndex - 1;
                }
                else if (current == stone)
                {
                    result[nextStoneIndex][rotatedColumn] = stone;
                    nextStoneIndex--;
                }
            }
        }

        return result;
    }
}
