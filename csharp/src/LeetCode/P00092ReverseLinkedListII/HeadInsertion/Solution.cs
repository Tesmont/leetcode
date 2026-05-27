namespace LeetCode.P00092ReverseLinkedListII.HeadInsertion;

/// <summary>
/// LeetCode #92 - Reverse Linked List II.
/// Problem: https://leetcode.com/problems/reverse-linked-list-ii/
/// </summary>
public sealed class Solution
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        ListNode dummyNode = new(0, head);
        ListNode previousNode = dummyNode;

        for (int i = 1; i < left; i++)
        {
            previousNode = previousNode.next!;
        }

        ListNode currentNode = previousNode.next!;
        for (int i = left; i < right; i++)
        {
            ListNode nextNode = currentNode.next!;
            currentNode.next = nextNode.next;
            nextNode.next = previousNode.next;
            previousNode.next = nextNode;
        }

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
