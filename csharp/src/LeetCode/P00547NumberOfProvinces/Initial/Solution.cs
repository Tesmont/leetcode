namespace LeetCode.P00547NumberOfProvinces.Initial;

/// <summary>
/// LeetCode 547. Number of Provinces.
/// https://leetcode.com/problems/number-of-provinces/
/// </summary>
public sealed class Solution
{
    public int FindCircleNum(int[][] isConnected)
    {
        bool[] seen = new bool[isConnected.Length];
        int provinceCount = 0;

        for (int city = 0; city < isConnected.Length; city++)
        {
            if (seen[city])
            {
                continue;
            }

            provinceCount++;
            Dfs(city);
        }

        return provinceCount;

        void Dfs(int city)
        {
            seen[city] = true;

            for (int connectedCity = 0; connectedCity < isConnected.Length; connectedCity++)
            {
                if (isConnected[city][connectedCity] == 1 && !seen[connectedCity])
                {
                    Dfs(connectedCity);
                }
            }
        }
    }
}
