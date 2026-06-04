namespace LeetCode.P00019RemoveNthNodeFromEndOfList.FastSlowPointers;

/// <summary>
/// LeetCode 19. Remove Nth Node From End of List.
/// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
/// </summary>
public sealed class Solution
{
    public ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new(0, head);
        ListNode slow = dummy;
        ListNode? fast = dummy;

        for (int i = 0; i <= n; i++)
        {
            fast = fast!.next;
        }

        while (fast != null)
        {
            slow = slow.next!;
            fast = fast.next;
        }

        slow.next = slow.next!.next;

        return dummy.next;
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
