namespace LeetCode.P02398MaximumNumberOfRobotsWithinBudget.Initial;

/// <summary>
/// LeetCode 2398. Maximum Number of Robots Within Budget.
/// https://leetcode.com/problems/maximum-number-of-robots-within-budget/
/// </summary>
public sealed class Solution
{
    public int MaximumRobots(int[] chargeTimes, int[] runningCosts, long budget)
    {
        Span<int> maxChargeTimes = stackalloc int[chargeTimes.Length];

        int head = 0;
        int tail = 0;
        long runningCostSum = 0;
        int leftIndex = 0;
        int result = 0;

        for (int rightIndex = 0; rightIndex < chargeTimes.Length; rightIndex++)
        {
            while (head < tail && chargeTimes[maxChargeTimes[tail - 1]] <= chargeTimes[rightIndex])
            {
                tail--;
            }

            maxChargeTimes[tail++] = rightIndex;
            runningCostSum += runningCosts[rightIndex];

            while (head < tail
                && chargeTimes[maxChargeTimes[head]] + (rightIndex - leftIndex + 1L) * runningCostSum > budget)
            {
                runningCostSum -= runningCosts[leftIndex];

                if (maxChargeTimes[head] == leftIndex)
                {
                    head++;
                }

                leftIndex++;
            }

            result = Math.Max(result, rightIndex - leftIndex + 1);
        }

        return result;
    }
}
