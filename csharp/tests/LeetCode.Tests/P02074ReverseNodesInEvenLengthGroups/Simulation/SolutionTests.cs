using LeetCode.P02074ReverseNodesInEvenLengthGroups.Simulation;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02074ReverseNodesInEvenLengthGroups.SolutionTestCases;

namespace LeetCode.Tests.P02074ReverseNodesInEvenLengthGroups.Simulation;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.ReverseEvenLengthGroupsCases), MemberType = typeof(RootSolutionTestCases))]
    public void ReverseEvenLengthGroups_ReversesNodesInEvenLengthGroups(int[] values, int[] expected)
    {
        Solution solution = new();
        ListNode head = BuildList(values);

        ListNode actual = solution.ReverseEvenLengthGroups(head);

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

    private static int[] ToArray(ListNode head)
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
