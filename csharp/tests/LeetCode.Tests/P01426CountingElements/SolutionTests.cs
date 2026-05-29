using LeetCode.P01426CountingElements;
using Xunit;

namespace LeetCode.Tests.P01426CountingElements;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.CountElementsCases), MemberType = typeof(SolutionTestCases))]
    public void CountElements_ReturnsCountOfElementsWithSuccessor(int[] arr, int expected)
    {
        Solution solution = new();

        int actual = solution.CountElements(arr);

        Assert.Equal(expected, actual);
    }
}
