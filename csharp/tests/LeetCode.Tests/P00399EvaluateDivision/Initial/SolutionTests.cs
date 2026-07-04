using LeetCode.P00399EvaluateDivision.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00399EvaluateDivision.SolutionTestCases;

namespace LeetCode.Tests.P00399EvaluateDivision.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.CalcEquationCases), MemberType = typeof(RootSolutionTestCases))]
    public void CalcEquation_ReturnsResults(
        IList<IList<string>> equations,
        double[] values,
        IList<IList<string>> queries,
        double[] expected)
    {
        Solution solution = new();

        double[] actual = solution.CalcEquation(equations, values, queries);

        Assert.Equal(expected.Length, actual.Length);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], actual[i], precision: 5);
        }
    }
}
