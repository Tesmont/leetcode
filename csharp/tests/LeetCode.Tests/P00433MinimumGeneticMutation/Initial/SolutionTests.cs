using LeetCode.P00433MinimumGeneticMutation.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00433MinimumGeneticMutation.SolutionTestCases;

namespace LeetCode.Tests.P00433MinimumGeneticMutation.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MinMutationCases), MemberType = typeof(RootSolutionTestCases))]
    public void MinMutation_ReturnsMinimumNumberOfMutations(
        string startGene,
        string endGene,
        string[] bank,
        int expected)
    {
        Solution solution = new();

        int actual = solution.MinMutation(startGene, endGene, bank);

        Assert.Equal(expected, actual);
    }
}
