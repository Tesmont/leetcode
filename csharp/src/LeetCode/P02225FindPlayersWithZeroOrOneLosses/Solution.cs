namespace LeetCode.P02225FindPlayersWithZeroOrOneLosses;

/// <summary>
/// LeetCode 2225. Find Players With Zero or One Losses.
/// https://leetcode.com/problems/find-players-with-zero-or-one-losses/
/// </summary>
public sealed class Solution
{
    public IList<IList<int>> FindWinners(int[][] matches)
    {
        const int winnerIndex = 0;
        const int loserIndex = 1;

        const int maxPlayerNumber = 100_000 + 1;
        Span<bool> seen = stackalloc bool[maxPlayerNumber];
        Span<int> losses = stackalloc int[maxPlayerNumber];

        for (int i = 0; i < matches.Length; i++)
        {
            int winner = matches[i][winnerIndex];
            seen[winner] = true;

            int loser = matches[i][loserIndex];
            seen[loser] = true;
            losses[loser]++;
        }

        List<int> tops = new(matches.Length);
        List<int> losers = new(matches.Length);

        for (int i = 1; i < losses.Length; i++)
        {
            if (!seen[i])
            {
                continue;
            }

            if (losses[i] == 0)
            {
                tops.Add(i);
            }
            else if (losses[i] == 1)
            {
                losers.Add(i);
            }
        }

        return [tops, losers];
    }
}
