namespace LeetCode.P02074ReverseNodesInEvenLengthGroups.Simulation;

/// <summary>
/// LeetCode 2074. Reverse Nodes in Even Length Groups.
/// https://leetcode.com/problems/reverse-nodes-in-even-length-groups/
/// </summary>
public sealed class Solution
{
    public ListNode ReverseEvenLengthGroups(ListNode head)
    {
        ListNode previousGroupTail = head;
        int groupLength = 2;

        while (previousGroupTail.next != null)
        {
            (ListNode groupTail, int actualLength) = GetGroupTail(previousGroupTail.next, groupLength);
            previousGroupTail = actualLength % 2 == 0
                ? ReverseGroup(previousGroupTail, actualLength)
                : groupTail;

            groupLength++;
        }

        return head;
    }

    private static (ListNode tail, int length) GetGroupTail(ListNode head, int maxGroupLength)
    {
        int length = 1;
        ListNode tail = head;

        while (tail.next != null
            && length < maxGroupLength)
        {
            tail = tail.next;
            length++;
        }

        return (tail, length);
    }

    private static ListNode ReverseGroup(ListNode previousGroupTail, int length)
    {
        ListNode groupHead = previousGroupTail.next!;
        ListNode? current = groupHead;
        ListNode? previous = null;
        int remaining = length;

        while (remaining > 0)
        {
            ListNode? next = current!.next;
            current.next = previous;
            previous = current;
            current = next;
            remaining--;
        }

        previousGroupTail.next = previous;
        groupHead.next = current;

        return groupHead;
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
