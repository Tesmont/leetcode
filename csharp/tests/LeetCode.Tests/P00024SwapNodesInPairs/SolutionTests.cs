using LeetCode.P00024SwapNodesInPairs;
using Xunit;

namespace LeetCode.Tests.P00024SwapNodesInPairs;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.SwapPairsCases), MemberType = typeof(SolutionTestCases))]
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
