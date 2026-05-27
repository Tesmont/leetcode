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
        ListNode? head = BuildList(values);

        ListNode? actual = solution.RemoveNthFromEnd(head, n);

        Assert.Equal(expected, ToArray(actual));
    }

    private static ListNode? BuildList(int[] values)
    {
        ListNode? head = null;

        for (int i = values.Length - 1; i >= 0; i--)
        {
            head = new ListNode(values[i], head);
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
