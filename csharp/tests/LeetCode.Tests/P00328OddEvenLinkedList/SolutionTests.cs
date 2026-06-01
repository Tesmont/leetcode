using LeetCode.P00328OddEvenLinkedList;
using Xunit;

namespace LeetCode.Tests.P00328OddEvenLinkedList;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.OddEvenListCases), MemberType = typeof(SolutionTestCases))]
    public void OddEvenList_GroupsOddIndexedNodesBeforeEvenIndexedNodes(int[] values, int[] expected)
    {
        Solution solution = new();
        ListNode? head = BuildList(values);

        ListNode? actual = solution.OddEvenList(head);

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
