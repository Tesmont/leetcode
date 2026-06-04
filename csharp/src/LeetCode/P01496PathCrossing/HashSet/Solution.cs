namespace LeetCode.P01496PathCrossing.HashSet;

/// <summary>
/// LeetCode 1496. Path Crossing.
/// https://leetcode.com/problems/path-crossing/
/// </summary>
public sealed class Solution
{
    public bool IsPathCrossing(string path)
    {
        const byte coordinateShiftBits = 32;
        HashSet<long> visited = new(path.Length + 1) { 0L };
        int x = 0;
        int y = 0;

        foreach (char direction in path)
        {
            switch (direction)
            {
                case 'N':
                    y++;
                    break;
                case 'S':
                    y--;
                    break;
                case 'E':
                    x++;
                    break;
                // case 'W':
                default:
                    x--;
                    break;
            }

            long key = ((long)x << coordinateShiftBits) | (uint)y;
            if (!visited.Add(key))
            {
                return true;
            }
        }

        return false;
    }
}
