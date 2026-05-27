using LeetCode.P00082RemoveDuplicatesFromSortedListII;
using Xunit;

namespace LeetCode.Tests.P00082RemoveDuplicatesFromSortedListII;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> DeleteDuplicatesCases =>
        new()
        {
            { [1, 2, 3, 3, 4, 4, 5], [1, 2, 5] },
            { [1, 1, 1, 2, 3], [2, 3] },
            { [], [] },
            { [1, 1], [] },
            { [1, 2, 2], [1] },
        };

    public static ListNode? BuildList(int[] values)
    {
        ListNode? head = null;

        for (int i = values.Length - 1; i >= 0; i--)
        {
            head = new ListNode(values[i], head);
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
