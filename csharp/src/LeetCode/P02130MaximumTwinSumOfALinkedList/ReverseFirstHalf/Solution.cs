namespace LeetCode.P02130MaximumTwinSumOfALinkedList.ReverseFirstHalf;

/// <summary>
/// LeetCode #2130 - Maximum Twin Sum of a Linked List.
/// Problem: https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/
/// </summary>
public sealed class Solution
{
    public int PairSum(ListNode head)
    {
        ListNode? previous = null;
        ListNode? slow = head;
        ListNode? fast = head;

        while (fast?.next != null)
        {
            fast = fast.next.next;
            ListNode? next = slow!.next;
            slow.next = previous;
            previous = slow;
            slow = next;
        }

        int maxSum = 0;
        while (slow != null)
        {
            maxSum = Math.Max(maxSum, previous!.val + slow.val);
            previous = previous.next;
            slow = slow.next;
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
