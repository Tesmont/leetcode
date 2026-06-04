namespace LeetCode.P01721SwappingNodesInALinkedList.NodeSwap;

/// <summary>
/// LeetCode 1721. Swapping Nodes in a Linked List.
/// https://leetcode.com/problems/swapping-nodes-in-a-linked-list/
/// </summary>
public sealed class Solution
{
    public ListNode SwapNodes(ListNode head, int k)
    {
        ListNode sentinel = new(0, head);
        ListNode predecessorFromStart = sentinel;

        for (int i = 1; i < k; i++)
        {
            predecessorFromStart = predecessorFromStart.next!;
        }

        ListNode predecessorFromEnd = sentinel;
        ListNode currentNode = predecessorFromStart.next!;

        while (currentNode.next != null)
        {
            currentNode = currentNode.next;
            predecessorFromEnd = predecessorFromEnd.next!;
        }

        ListNode nodeFromStart = predecessorFromStart.next!;
        ListNode nodeFromEnd = predecessorFromEnd.next!;

        if (nodeFromStart == nodeFromEnd)
        {
            return sentinel.next!;
        }

        if (nodeFromStart.next == nodeFromEnd)
        {
            nodeFromStart.next = nodeFromEnd.next;
            nodeFromEnd.next = nodeFromStart;
            predecessorFromStart.next = nodeFromEnd;

            return sentinel.next!;
        }

        if (nodeFromEnd.next == nodeFromStart)
        {
            nodeFromEnd.next = nodeFromStart.next;
            nodeFromStart.next = nodeFromEnd;
            predecessorFromEnd.next = nodeFromStart;

            return sentinel.next!;
        }

        predecessorFromStart.next = nodeFromEnd;
        predecessorFromEnd.next = nodeFromStart;

        ListNode? nextAfterStart = nodeFromStart.next;
        nodeFromStart.next = nodeFromEnd.next;
        nodeFromEnd.next = nextAfterStart;

        return sentinel.next!;
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
