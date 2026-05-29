using LeetCode.P00876MiddleOfTheLinkedList;
using Xunit;

namespace LeetCode.Tests.P00876MiddleOfTheLinkedList;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.MiddleNodeCases), MemberType = typeof(SolutionTestCases))]
    public void MiddleNode_ReturnsMiddleNode(int[] values, int expectedIndex)
    {
        Solution solution = new();
        ListNode head = BuildList(values);
        ListNode expected = GetNodeAt(head, expectedIndex);

        ListNode actual = solution.MiddleNode(head);

        Assert.Same(expected, actual);
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

    private static ListNode GetNodeAt(ListNode head, int index)
    {
        ListNode current = head;

        for (int i = 0; i < index; i++)
        {
            current = current.next!;
        }

        return current;
    }
}
