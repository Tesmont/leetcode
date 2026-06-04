namespace LeetCode.P00739DailyTemperatures;

/// <summary>
/// LeetCode 739. Daily Temperatures.
/// https://leetcode.com/problems/daily-temperatures/
/// </summary>
public sealed class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] result = new int[temperatures.Length];
        Stack<int> stack = new(temperatures.Length);

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.TryPeek(out int previousIndex)
                && temperatures[previousIndex] < temperatures[i])
            {
                result[previousIndex] = i - previousIndex;
                stack.Pop();
            }

            stack.Push(i);
        }

        return result;
    }
}
