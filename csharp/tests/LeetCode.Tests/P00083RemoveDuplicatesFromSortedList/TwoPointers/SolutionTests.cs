using LeetCode.P00083RemoveDuplicatesFromSortedList.TwoPointers;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00083RemoveDuplicatesFromSortedList.SolutionTestCases;
using TwoPointersSolution = LeetCode.P00083RemoveDuplicatesFromSortedList.TwoPointers.Solution;

namespace LeetCode.Tests.P00083RemoveDuplicatesFromSortedList.TwoPointers;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.DeleteDuplicatesCases), MemberType = typeof(RootSolutionTestCases))]
    public void DeleteDuplicates_RemovesDuplicatesFromSortedList(int[] values, int[] expected)
    {
        TwoPointersSolution solution = new();
        ListNode? head = BuildList(values);

        ListNode? actual = solution.DeleteDuplicates(head);

        Assert.Equal(expected, ToArray(actual));
    }

    private static ListNode? BuildList(int[] values)
    {
        ListNode? head = null;

        for (int i = values.Length - 1; i >= 0; i--)
        {
            head = new ListNode(values[i], head);
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
