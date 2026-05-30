namespace LeetCode.P00234PalindromeLinkedList;

/// <summary>
/// LeetCode #234 - Palindrome Linked List.
/// Problem: https://leetcode.com/problems/palindrome-linked-list/
/// </summary>
public sealed class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        ListNode middleNode = GetMiddleNode(head);
        ListNode? reversedNode = Reverse(middleNode);

        return StartsWithSameValues(head, reversedNode);
    }

    private static ListNode GetMiddleNode(ListNode head)
    {
        ListNode slow = head;
        ListNode? fast = head;

        while (fast?.next != null)
        {
            slow = slow.next!;
            fast = fast.next.next;
        }

        return slow;
    }

    private static ListNode? Reverse(ListNode head)
    {
        ListNode? previous = null;
        ListNode? current = head;

        while (current != null)
        {
            ListNode? next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        return previous;
    }

    private static bool StartsWithSameValues(ListNode head, ListNode? reveresed)
    {
        while (reveresed != null)
        {
            if (head.val != reveresed.val)
            {
                return false;
            }

            head = head.next!;
            reveresed = reveresed.next;
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
