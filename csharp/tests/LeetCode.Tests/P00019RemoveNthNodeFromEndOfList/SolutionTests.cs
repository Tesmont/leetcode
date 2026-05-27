using LeetCode.P00019RemoveNthNodeFromEndOfList;
using Xunit;

namespace LeetCode.Tests.P00019RemoveNthNodeFromEndOfList;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.RemoveNthFromEndCases), MemberType = typeof(SolutionTestCases))]
    public void RemoveNthFromEnd_RemovesExpectedNode(int[] values, int n, int[] expected)
    {
        Solution solution = new();
        ListNode head = BuildList(values);

        ListNode? actual = solution.RemoveNthFromEnd(head, n);

        Assert.Equal(expected, ToArray(actual));
    }

    private static ListNode BuildList(int[] values)
    {
        ListNode head = new(values[0]);
        ListNode current = head;

        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }

        return head;
    }

    private static int[] ToArray(ListNode? head)
    {
        List<int> values = [];
        ListNode? current = head;

        while (current != null)
        {
            values.Add(current.val);
            current = current.next;
        }

        return [.. values];
    }
}
