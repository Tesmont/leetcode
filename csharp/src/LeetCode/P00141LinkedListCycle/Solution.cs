namespace LeetCode.P00141LinkedListCycle;

/// <summary>
/// LeetCode #141 - Linked List Cycle.
/// Problem: https://leetcode.com/problems/linked-list-cycle/
/// </summary>
public sealed class Solution
{
    public bool HasCycle(ListNode? head)
    {
        ListNode? slow = head;
        ListNode? fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow!.next;
            fast = fast.next.next;

            if (slow == fast)
            {
                return true;
            }
        }

        return false;
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
