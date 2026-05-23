using LeetCode.P00092ReverseLinkedListII;
using Xunit;

namespace LeetCode.Tests.P00092ReverseLinkedListII;

public sealed class SolutionTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 2, 4, new[] { 1, 4, 3, 2, 5 })]
    [InlineData(new[] { 5 }, 1, 1, new[] { 5 })]
    [InlineData(new[] { 3, 5 }, 1, 2, new[] { 5, 3 })]
    public void ReverseBetween_ReversesNodesBetweenPositions(
        int[] values,
        int left,
        int right,
        int[] expected)
    {
        Solution solution = new();
        ListNode? head = BuildList(values);

        ListNode? actual = solution.ReverseBetween(head, left, right);

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
