using LeetCode.P01426CountingElements;
using Xunit;

namespace LeetCode.Tests.P01426CountingElements;

public sealed class SolutionTests
{
    public static TheoryData<int[], int> CountElementsCases =>
        new()
        {
            { [1, 2, 3], 2 },
            { [1, 1, 3, 3, 5, 5, 7, 7], 0 },
        };

    [Theory]
    [MemberData(nameof(CountElementsCases))]
    public void CountElements_ReturnsCountOfElementsWithSuccessor(int[] arr, int expected)
    {
        Solution solution = new();

        int actual = solution.CountElements(arr);

        Assert.Equal(expected, actual);
    }
}
