namespace LeetCode.P00239SlidingWindowMaximum.Initial;

/// <summary>
/// LeetCode 239. Sliding Window Maximum.
/// https://leetcode.com/problems/sliding-window-maximum/
/// </summary>
public sealed class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        LinkedList<int> deque = new();
        int[] slidingWindows = new int[nums.Length - k + 1];

        for (int i = 0; i < nums.Length; i++)
        {
            if (deque.Count > 0 
                && deque.First!.Value == i - k)
            {
                deque.RemoveFirst();
            }

            while (deque.Count > 0
                && nums[deque.Last!.Value] <= nums[i])
            {
                deque.RemoveLast();
            }

            deque.AddLast(i);

            if (i >= k - 1)
            {
                slidingWindows[i - k + 1] = nums[deque.First!.Value];
            }
        }

        return slidingWindows;
    }
}
