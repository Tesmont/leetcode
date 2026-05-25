namespace LeetCode.P02095DeleteTheMiddleNodeOfALinkedList;

/// <summary>
/// LeetCode #2095 - Delete the Middle Node of a Linked List.
/// Problem: https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/
/// </summary>
public sealed class Solution
{
    public ListNode? DeleteMiddle(ListNode head)
    {
        if (head.next is null)
        {
            return null;
        }

        ListNode slow = head;
        ListNode? fast = head.next?.next;

        while (fast?.next != null)
        {
            slow = slow.next!;
            fast = fast.next.next;
        }

        slow.next = slow.next!.next;
        return head;
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
