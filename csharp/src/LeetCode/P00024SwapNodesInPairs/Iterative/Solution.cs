namespace LeetCode.P00024SwapNodesInPairs.Iterative;

/// <summary>
/// LeetCode 24. Swap Nodes in Pairs.
/// https://leetcode.com/problems/swap-nodes-in-pairs/
/// </summary>
public sealed class Solution
{
    public ListNode? SwapPairs(ListNode? head)
    {
        ListNode dummy = new(0, head);
        ListNode current = dummy;

        while (current.next?.next != null)
        {
            ListNode first = current.next;
            ListNode second = first.next;

            first.next = second.next;
            second.next = first;
            current.next = second;

            current = first;
        }

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
