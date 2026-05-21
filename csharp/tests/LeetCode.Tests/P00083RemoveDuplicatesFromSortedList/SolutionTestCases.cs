using LeetCode.P00083RemoveDuplicatesFromSortedList;
using Xunit;

namespace LeetCode.Tests.P00083RemoveDuplicatesFromSortedList;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> DeleteDuplicatesCases =>
        new()
        {
            { [1, 1, 2], [1, 2] },
            { [1, 1, 2, 3, 3], [1, 2, 3] },
            { [], [] },
        };

    public static ListNode? BuildList(int[] values)
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

    public static int[] ToArray(ListNode? head)
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
