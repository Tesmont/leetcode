using System.Text.Json.Serialization;

namespace LeetCode.P00001TwoSum;

public sealed class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new();
        dict[nums[0]] = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            int num = nums[i];
            int addend = target - num;
            if (dict.TryGetValue(addend, out int addendIndex))
            {
                return [addendIndex, i];
            }

            dict[num] = i;
        }

        return [];
    }
}
