using LeetCode.P02248IntersectionOfMultipleArrays;
using Xunit;

namespace LeetCode.Tests.P02248IntersectionOfMultipleArrays;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.IntersectionCases), MemberType = typeof(SolutionTestCases))]
    public void Intersection_ReturnsSortedIntersection(int[][] nums, int[] expected)
    {
        Solution solution = new();

        IList<int> actual = solution.Intersection(nums);

        Assert.Equal(expected, actual);
    }
}
