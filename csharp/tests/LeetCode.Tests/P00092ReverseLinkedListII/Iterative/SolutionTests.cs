using LeetCode.P00092ReverseLinkedListII.Iterative;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00092ReverseLinkedListII.SolutionTestCases;

namespace LeetCode.Tests.P00092ReverseLinkedListII.Iterative;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.ReverseBetweenCases), MemberType = typeof(RootSolutionTestCases))]
    public void ReverseBetween_ReversesNodesBetweenPositions(
        int[] values,
        int left,
        int right,
        int[] expected)
    {
        Solution solution = new();
        ListNode head = BuildList(values);

        ListNode actual = solution.ReverseBetween(head, left, right);

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
