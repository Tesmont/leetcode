namespace LeetCode.P00739DailyTemperatures.Jumping;

/// <summary>
/// LeetCode 739. Daily Temperatures.
/// https://leetcode.com/problems/daily-temperatures/
/// </summary>
public sealed class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] result = new int[temperatures.Length];
        int warmestToRight = int.MinValue;

        for (int i = temperatures.Length - 1; i >= 0; i--)
        {
            int temperature = temperatures[i];
            if (temperature >= warmestToRight)
            {
                warmestToRight = temperature;
                continue;
            }

            int wait = 1;
            while (temperatures[i + wait] <= temperature)
            {
                wait += result[i + wait];
            }

            result[i] = wait;
        }

        return result;
    }
}
