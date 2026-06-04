namespace LeetCode.P00234PalindromeLinkedList.ReverseSecondHalf;

/// <summary>
/// LeetCode 234. Palindrome Linked List.
/// https://leetcode.com/problems/palindrome-linked-list/
/// </summary>
public sealed class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        ListNode? fast = head;
        ListNode? secondHalf = head;
        ListNode? reversedFirstHalf = null;

        while (fast?.next != null)
        {
            fast = fast.next.next;

            ListNode next = secondHalf.next!;
            secondHalf.next = reversedFirstHalf;
            reversedFirstHalf = secondHalf;
            secondHalf = next;
        }

        if (fast != null)
        {
            secondHalf = secondHalf.next;
        }

        while (secondHalf != null)
        {
            if (secondHalf.val != reversedFirstHalf!.val)
            {
                return false;
            }

            secondHalf = secondHalf.next;
            reversedFirstHalf = reversedFirstHalf.next;
        }

        return true;
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
