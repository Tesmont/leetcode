using LeetCode.P01290ConvertBinaryNumberInALinkedListToInteger.LinkedListTraversal;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01290ConvertBinaryNumberInALinkedListToInteger.SolutionTestCases;

namespace LeetCode.Tests.P01290ConvertBinaryNumberInALinkedListToInteger.LinkedListTraversal;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.GetDecimalValueCases), MemberType = typeof(RootSolutionTestCases))]
    public void GetDecimalValue_ReturnsDecimalValue(int[] values, int expected)
    {
        Solution solution = new();
        ListNode head = BuildList(values);

        int actual = solution.GetDecimalValue(head);

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
