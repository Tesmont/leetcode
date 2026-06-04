namespace LeetCode.P00083RemoveDuplicatesFromSortedList.TwoPointers;

/// <summary>
/// LeetCode 83. Remove Duplicates from Sorted List.
/// https://leetcode.com/problems/remove-duplicates-from-sorted-list/
/// </summary>
public sealed class Solution
{
    public ListNode? DeleteDuplicates(ListNode? head)
    {
        ListNode? current = head;
        while (current != null)
        {
            ListNode? nextDistinct = current.next;
            while (current.val == nextDistinct?.val)
            {
                nextDistinct = nextDistinct.next;
            }

            current.next = nextDistinct;
            current = nextDistinct;
        }

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
