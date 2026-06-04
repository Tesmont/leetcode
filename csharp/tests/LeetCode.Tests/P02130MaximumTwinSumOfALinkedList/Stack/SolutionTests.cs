using LeetCode.P02130MaximumTwinSumOfALinkedList.Stack;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02130MaximumTwinSumOfALinkedList.SolutionTestCases;

namespace LeetCode.Tests.P02130MaximumTwinSumOfALinkedList.Stack;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.PairSumCases), MemberType = typeof(RootSolutionTestCases))]
    public void PairSum_ReturnsMaximumTwinSum(int[] values, int expected)
    {
        Solution solution = new();
        ListNode head = BuildList(values);

        int actual = solution.PairSum(head);

        Assert.Equal(expected, actual);
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
}
