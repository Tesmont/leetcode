using LeetCode.P00082RemoveDuplicatesFromSortedListII;
using Xunit;

namespace LeetCode.Tests.P00082RemoveDuplicatesFromSortedListII;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.DeleteDuplicatesCases), MemberType = typeof(SolutionTestCases))]
    public void DeleteDuplicates_RemovesAllDuplicateValuesFromSortedList(int[] values, int[] expected)
    {
        Solution solution = new();
        ListNode? head = SolutionTestCases.BuildList(values);

        ListNode? actual = solution.DeleteDuplicates(head);

        Assert.Equal(expected, SolutionTestCases.ToArray(actual));
    }
}
