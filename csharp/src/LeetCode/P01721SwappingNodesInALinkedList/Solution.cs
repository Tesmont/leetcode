namespace LeetCode.P01721SwappingNodesInALinkedList;

/// <summary>
/// LeetCode #1721 - Swapping Nodes in a Linked List.
/// Problem: https://leetcode.com/problems/swapping-nodes-in-a-linked-list/
/// </summary>
public sealed class Solution
{
    public ListNode SwapNodes(ListNode head, int k)
    {
        ListNode? currentNode = head;
        ListNode? kthFromStart = null;
        ListNode? kthFromEnd = null;

        int length = 0;
        while (currentNode != null)
        {
            length++;

            if (length == k)
            {
                kthFromStart = currentNode;
                kthFromEnd = head;
            }
            else
            {
                kthFromEnd = kthFromEnd?.next;
            }

            currentNode = currentNode.next;
        }

        int temp = kthFromStart!.val;
        kthFromStart.val = kthFromEnd!.val;
        kthFromEnd.val = temp;

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
