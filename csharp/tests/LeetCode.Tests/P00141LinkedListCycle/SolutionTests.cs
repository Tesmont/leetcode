using LeetCode.P00141LinkedListCycle;
using Xunit;

namespace LeetCode.Tests.P00141LinkedListCycle;

public sealed class SolutionTests
{
    [Theory]
    [InlineData(new[] { 3, 2, 0, -4 }, 1, true)]
    [InlineData(new[] { 1, 2 }, 0, true)]
    [InlineData(new[] { 1 }, -1, false)]
    [InlineData(new int[] { }, -1, false)]
    public void HasCycle_ReturnsWhetherLinkedListHasCycle(int[] values, int pos, bool expected)
    {
        Solution solution = new();
        ListNode? head = BuildList(values, pos);

        bool actual = solution.HasCycle(head);

        Assert.Equal(expected, actual);
    }

    private static ListNode? BuildList(int[] values, int pos)
    {
        if (values.Length == 0)
        {
            return null;
        }

        ListNode head = new(values[0]);
        ListNode current = head;
        ListNode? cycleNode = pos == 0 ? head : null;

        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;

            if (i == pos)
            {
                cycleNode = current;
            }
        }

        current.next = cycleNode;

        return head;
    }
}
