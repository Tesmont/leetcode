using LeetCode.P00024SwapNodesInPairs;
using Xunit;

namespace LeetCode.Tests.P00024SwapNodesInPairs;

public sealed class SolutionTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 2, 1, 4, 3 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 2, 1, 3 })]
    public void SwapPairs_SwapsAdjacentNodes(int[] values, int[] expected)
    {
        Solution solution = new();
        ListNode? head = BuildList(values);

        ListNode? actual = solution.SwapPairs(head);

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
