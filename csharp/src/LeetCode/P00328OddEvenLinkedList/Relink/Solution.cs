namespace LeetCode.P00328OddEvenLinkedList.Relink;

/// <summary>
/// LeetCode 328. Odd Even Linked List.
/// https://leetcode.com/problems/odd-even-linked-list/
/// </summary>
public sealed class Solution
{
    public ListNode? OddEvenList(ListNode? head)
    {
        if (head == null)
        {
            return null;
        }

        ListNode odd = head;
        ListNode? even = head.next;
        ListNode? evenHead = even;

        while (even?.next != null)
        {
            odd.next = even.next;
            odd = odd.next;

            even.next = odd.next;
            even = even.next;
        }

        odd.next = evenHead;

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
