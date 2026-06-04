namespace LeetCode.P00082RemoveDuplicatesFromSortedListII.Sentinel;

/// <summary>
/// LeetCode 82. Remove Duplicates from Sorted List II.
/// https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/
/// </summary>
public sealed class Solution
{
    public ListNode? DeleteDuplicates(ListNode? head)
    {
        ListNode sentinel = new(0, head);
        ListNode previousDistinct = sentinel;
        ListNode? current = head;

        while (current?.next != null)
        {
            if (current.val != current.next.val)
            {
                previousDistinct = current;
                current = current.next;
                continue;
            }

            int duplicateValue = current.val;
            while (current?.val == duplicateValue)
            {
                current = current.next;
            }

            previousDistinct.next = current;
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
