using LeetCode.P01721SwappingNodesInALinkedList.TwoPointers;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01721SwappingNodesInALinkedList.SolutionTestCases;

namespace LeetCode.Tests.P01721SwappingNodesInALinkedList.TwoPointers;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.SwapNodesCases), MemberType = typeof(RootSolutionTestCases))]
    public void SwapNodes_SwapsKthNodeFromBeginningAndEnd(
        int[] values,
        int k,
        int[] expected)
    {
        Solution solution = new();
        ListNode head = BuildList(values);

        ListNode actual = solution.SwapNodes(head, k);

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
