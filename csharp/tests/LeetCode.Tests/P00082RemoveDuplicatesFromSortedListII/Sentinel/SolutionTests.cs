using LeetCode.P00082RemoveDuplicatesFromSortedListII.Sentinel;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00082RemoveDuplicatesFromSortedListII.SolutionTestCases;

namespace LeetCode.Tests.P00082RemoveDuplicatesFromSortedListII.Sentinel;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.DeleteDuplicatesCases), MemberType = typeof(RootSolutionTestCases))]
    public void DeleteDuplicates_RemovesAllDuplicateValuesFromSortedList(int[] values, int[] expected)
    {
        Solution solution = new();
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
