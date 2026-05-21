using LeetCode.P00083RemoveDuplicatesFromSortedList;
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
        ListNode? head = RootSolutionTestCases.BuildList(values);

        ListNode? actual = solution.DeleteDuplicates(head);

        Assert.Equal(expected, RootSolutionTestCases.ToArray(actual));
    }
}
