namespace LeetCode.P00203RemoveLinkedListElements;

/// <summary>
/// LeetCode #203 - Remove Linked List Elements.
/// Problem: https://leetcode.com/problems/remove-linked-list-elements/
/// </summary>
public sealed class Solution
{
    public ListNode? RemoveElements(ListNode? head, int val)
    {
        ListNode sentinel = new(0, head);
        ListNode previous = sentinel;
        ListNode? current = head;

        while (current != null)
        {
            if (current.val == val)
            {
                previous.next = current.next;
            }
            else
            {
                previous = current;
            }

            current = current.next;
        }

        return sentinel.next;
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
