using LeetCode.P00912SortAnArray.MinHeap;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00912SortAnArray.SolutionTestCases;

namespace LeetCode.Tests.P00912SortAnArray.MinHeap;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.SortArrayCases), MemberType = typeof(RootSolutionTestCases))]
    public void SortArray_ReturnsSortedArray(int[] nums, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.SortArray(nums);

        Assert.Equal(expected, actual);
    }
}
