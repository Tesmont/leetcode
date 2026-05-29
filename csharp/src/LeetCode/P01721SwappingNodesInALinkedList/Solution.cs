namespace LeetCode.P01721SwappingNodesInALinkedList;

/// <summary>
/// LeetCode #1721 - Swapping Nodes in a Linked List.
/// Problem: https://leetcode.com/problems/swapping-nodes-in-a-linked-list/
/// </summary>
public sealed class Solution
{
    public ListNode SwapNodes(ListNode head, int k)
    {
        ListNode nodeFromStart = head;
        for (int i = 1; i < k; i++)
        {
            nodeFromStart = nodeFromStart.next!;
        }

        ListNode nodeFromEnd = head;
        ListNode? currentNode = nodeFromStart.next;

        while (currentNode != null)
        {
            currentNode = currentNode.next;
            nodeFromEnd = nodeFromEnd.next!;
        }

        int tempVal = nodeFromStart.val;
        nodeFromStart.val = nodeFromEnd.val;
        nodeFromEnd.val = tempVal;

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
