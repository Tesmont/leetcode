using Xunit;

namespace LeetCode.Tests.P00399EvaluateDivision;

public static class SolutionTestCases
{
    public static TheoryData<IList<IList<string>>, double[], IList<IList<string>>, double[]> CalcEquationCases =>
        new()
        {
            {
                new List<IList<string>>
                {
                    new List<string> { "a", "b" },
                    new List<string> { "b", "c" },
                },
                [2.0, 3.0],
                new List<IList<string>>
                {
                    new List<string> { "a", "c" },
                    new List<string> { "b", "a" },
                    new List<string> { "a", "e" },
                    new List<string> { "a", "a" },
                    new List<string> { "x", "x" },
                },
                [6.0, 0.5, -1.0, 1.0, -1.0]
            },
            {
                new List<IList<string>>
                {
                    new List<string> { "a", "b" },
                    new List<string> { "b", "c" },
                    new List<string> { "bc", "cd" },
                },
                [1.5, 2.5, 5.0],
                new List<IList<string>>
                {
                    new List<string> { "a", "c" },
                    new List<string> { "c", "b" },
                    new List<string> { "bc", "cd" },
                    new List<string> { "cd", "bc" },
                },
                [3.75, 0.4, 5.0, 0.2]
            },
            {
                new List<IList<string>>
                {
                    new List<string> { "a", "b" },
                },
                [0.5],
                new List<IList<string>>
                {
                    new List<string> { "a", "b" },
                    new List<string> { "b", "a" },
                    new List<string> { "a", "c" },
                    new List<string> { "x", "y" },
                },
                [0.5, 2.0, -1.0, -1.0]
            },
        };
}
