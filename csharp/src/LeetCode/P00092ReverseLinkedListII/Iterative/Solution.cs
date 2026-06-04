namespace LeetCode.P00092ReverseLinkedListII.Iterative;

/// <summary>
/// LeetCode 92. Reverse Linked List II.
/// https://leetcode.com/problems/reverse-linked-list-ii/
/// </summary>
public sealed class Solution
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        ListNode dummyNode = new(0, head);
        ListNode before = dummyNode;

        for (int i = 1; i < left; i++)
        {
            before = before.next!;
        }

        ListNode sublistTail = before.next!;
        ListNode? previous = null;
        ListNode? current = sublistTail;

        for (int i = left; i <= right; i++)
        {
            ListNode? next = current!.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        before.next = previous;
        sublistTail.next = current;

        return dummyNode.next!;
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
