using LeetCode.P02248IntersectionOfMultipleArrays;
using Xunit;

namespace LeetCode.Tests.P02248IntersectionOfMultipleArrays;

public sealed class SolutionTests
{
    public static TheoryData<int[][], int[]> IntersectionCases =>
        new()
        {
            { [[3, 1, 2, 4, 5], [1, 2, 3, 4], [3, 4, 5, 6]], [3, 4] },
            { [[1, 2, 3], [4, 5, 6]], [] },
        };

    [Theory]
    [MemberData(nameof(IntersectionCases))]
    public void Intersection_ReturnsSortedIntersection(int[][] nums, int[] expected)
    {
        Solution solution = new();

        IList<int> actual = solution.Intersection(nums);

        Assert.Equal(expected, actual);
    }
}
