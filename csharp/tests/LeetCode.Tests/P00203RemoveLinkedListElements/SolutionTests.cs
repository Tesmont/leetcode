using LeetCode.P00203RemoveLinkedListElements;
using Xunit;

namespace LeetCode.Tests.P00203RemoveLinkedListElements;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.RemoveElementsCases), MemberType = typeof(SolutionTestCases))]
    public void RemoveElements_RemovesMatchingNodes(int[] values, int val, int[] expected)
    {
        Solution solution = new();
        ListNode? head = BuildList(values);

        ListNode? actual = solution.RemoveElements(head, val);

        Assert.Equal(expected, ToArray(actual));
    }

    private static ListNode? BuildList(int[] values)
    {
        if (values.Length == 0)
        {
            return null;
        }

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
