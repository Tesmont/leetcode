namespace LeetCode.P02130MaximumTwinSumOfALinkedList.ReverseSecondHalf;

/// <summary>
/// LeetCode 2130. Maximum Twin Sum of a Linked List.
/// https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/
/// </summary>
public sealed class Solution
{
    public int PairSum(ListNode head)
    {
        ListNode middleNode = GetMiddleNode(head);
        ListNode? reversedNode = Reverse(middleNode);

        int maxSum = 0;
        while (reversedNode != null)
        {
            maxSum = Math.Max(maxSum, head.val + reversedNode.val);
            head = head.next!;
            reversedNode = reversedNode.next;
        }

        return maxSum;
    }

    private static ListNode GetMiddleNode(ListNode head)
    {
        ListNode slow = head;
        ListNode? fast = head;

        while (fast?.next != null)
        {
            slow = slow.next!;
            fast = fast.next.next;
        }

        return slow;
    }

    private static ListNode? Reverse(ListNode head)
    {
        ListNode? previous = null;
        ListNode? current = head;

        while (current != null)
        {
            ListNode? next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        return previous;
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
