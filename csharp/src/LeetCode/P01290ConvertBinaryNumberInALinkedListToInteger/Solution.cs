namespace LeetCode.P01290ConvertBinaryNumberInALinkedListToInteger;

/// <summary>
/// LeetCode 1290. Convert Binary Number in a Linked List to Integer.
/// https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
/// </summary>
public sealed class Solution
{
    public int GetDecimalValue(ListNode head)
    {
        ListNode? current = head;
        int result = 0;

        while (current != null)
        {
            result <<= 1;
            result |= current.val;
            current = current.next;
        }

        return result;
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
