using LeetCode.P01426CountingElements.HashSet;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01426CountingElements.SolutionTestCases;

namespace LeetCode.Tests.P01426CountingElements.HashSet;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.CountElementsCases), MemberType = typeof(RootSolutionTestCases))]
    public void CountElements_ReturnsCountOfElementsWithSuccessor(int[] arr, int expected)
    {
        Solution solution = new();

        int actual = solution.CountElements(arr);

        Assert.Equal(expected, actual);
    }
}
