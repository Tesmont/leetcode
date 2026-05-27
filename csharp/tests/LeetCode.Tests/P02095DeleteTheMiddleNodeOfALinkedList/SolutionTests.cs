using LeetCode.P02095DeleteTheMiddleNodeOfALinkedList;
using Xunit;

namespace LeetCode.Tests.P02095DeleteTheMiddleNodeOfALinkedList;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.DeleteMiddleCases), MemberType = typeof(SolutionTestCases))]
    public void DeleteMiddle_DeletesMiddleNode(int[] values, int[] expected)
    {
        Solution solution = new();
        ListNode head = BuildList(values);

        ListNode? actual = solution.DeleteMiddle(head);

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
