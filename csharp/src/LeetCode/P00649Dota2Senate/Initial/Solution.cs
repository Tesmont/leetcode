namespace LeetCode.P00649Dota2Senate.Initial;

/// <summary>
/// LeetCode 649. Dota2 Senate.
/// https://leetcode.com/problems/dota2-senate/
/// </summary>
public sealed class Solution
{
    public string PredictPartyVictory(string senate)
    {
        Queue<int> radiant = new();
        Queue<int> dire = new();

        for (int i = 0; i < senate.Length; i++)
        {
            if (senate[i] == 'R')
            {
                radiant.Enqueue(i);
            }
            else
            {
                dire.Enqueue(i);
            }
        }

        int roundOffset = senate.Length;
        while (radiant.Count > 0 && dire.Count > 0)
        {
            int radiantTurn = radiant.Dequeue();
            int direTurn = dire.Dequeue();

            if (radiantTurn < direTurn)
            {
                radiant.Enqueue(radiantTurn + roundOffset);
            }
            else
            {
                dire.Enqueue(direTurn + roundOffset);
            }
        }

        return radiant.Count > 0
            ? "Radiant"
            : "Dire";
    }
}
