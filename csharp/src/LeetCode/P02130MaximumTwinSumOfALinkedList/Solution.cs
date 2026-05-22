namespace LeetCode.P02130MaximumTwinSumOfALinkedList;

/// <summary>
/// LeetCode #2130 - Maximum Twin Sum of a Linked List.
/// Problem: https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/
/// </summary>
public sealed class Solution
{
    public int PairSum(ListNode? head)
    {
        const int maxNodesCount = 100_000;
        Span<int> vals = stackalloc int[maxNodesCount];
        int valsCount = 0;
        while (head != null)
        {
            vals[valsCount] = head.val;
            valsCount++;
            head = head.next;
        }

        int maxSum = 0;
        int leftIndex = 0;
        int rightIndex = valsCount - 1;
        while (leftIndex < rightIndex)
        {
            int sum = vals[leftIndex] + vals[rightIndex];
            maxSum = Math.Max(maxSum, sum);
            leftIndex++;
            rightIndex--;
        }

        return maxSum;
    }
}

public sealed class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}
