using LeetCode.P00547NumberOfProvinces.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00547NumberOfProvinces.SolutionTestCases;

namespace LeetCode.Tests.P00547NumberOfProvinces.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.FindCircleNumCases), MemberType = typeof(RootSolutionTestCases))]
    public void FindCircleNum_ReturnsNumberOfProvinces(int[][] isConnected, int expected)
    {
        Solution solution = new();

        int actual = solution.FindCircleNum(isConnected);

        Assert.Equal(expected, actual);
    }
}
