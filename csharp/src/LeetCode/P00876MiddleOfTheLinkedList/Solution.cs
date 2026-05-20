namespace LeetCode.P00876MiddleOfTheLinkedList;

/// <summary>
/// LeetCode #876 - Middle of the Linked List.
/// Problem: https://leetcode.com/problems/middle-of-the-linked-list/
/// </summary>
public sealed class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode slow = head;
        ListNode? fast = head;
        while (fast?.next != null)
        {
            slow = slow.next!;
            fast = fast.next?.next;
        }

        return slow;
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
