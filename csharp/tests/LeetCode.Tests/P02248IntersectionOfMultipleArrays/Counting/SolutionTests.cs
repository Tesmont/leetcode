using LeetCode.P02248IntersectionOfMultipleArrays.Counting;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02248IntersectionOfMultipleArrays.SolutionTestCases;

namespace LeetCode.Tests.P02248IntersectionOfMultipleArrays.Counting;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.IntersectionCases), MemberType = typeof(RootSolutionTestCases))]
    public void Intersection_ReturnsSortedIntersection(int[][] nums, int[] expected)
    {
        Solution solution = new();

        IList<int> actual = solution.Intersection(nums);

        Assert.Equal(expected, actual);
    }
}
