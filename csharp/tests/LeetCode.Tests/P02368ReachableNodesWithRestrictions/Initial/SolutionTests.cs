using LeetCode.P02368ReachableNodesWithRestrictions.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02368ReachableNodesWithRestrictions.SolutionTestCases;

namespace LeetCode.Tests.P02368ReachableNodesWithRestrictions.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.ReachableNodesCases), MemberType = typeof(RootSolutionTestCases))]
    public void ReachableNodes_ReturnsMaximumReachableNodeCount(
        int n,
        int[][] edges,
        int[] restricted,
        int expected)
    {
        Solution solution = new();

        int actual = solution.ReachableNodes(n, edges, restricted);

        Assert.Equal(expected, actual);
    }
}
