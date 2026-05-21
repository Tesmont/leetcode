using LeetCode.P00083RemoveDuplicatesFromSortedList;
using Xunit;

namespace LeetCode.Tests.P00083RemoveDuplicatesFromSortedList;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.DeleteDuplicatesCases), MemberType = typeof(SolutionTestCases))]
    public void DeleteDuplicates_RemovesDuplicatesFromSortedList(int[] values, int[] expected)
    {
        Solution solution = new();
        ListNode? head = SolutionTestCases.BuildList(values);

        ListNode? actual = solution.DeleteDuplicates(head);

        Assert.Equal(expected, SolutionTestCases.ToArray(actual));
    }
}
