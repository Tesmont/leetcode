using Xunit;

namespace LeetCode.Tests.P00433MinimumGeneticMutation;

public static class SolutionTestCases
{
    public static TheoryData<string, string, string[], int> MinMutationCases =>
        new()
        {
            { "AACCGGTT", "AACCGGTA", ["AACCGGTA"], 1 },
            { "AACCGGTT", "AAACGGTA", ["AACCGGTA", "AACCGCTA", "AAACGGTA"], 2 },
            { "AAAAACCC", "AACCCCCC", ["AAAACCCC", "AAACCCCC", "AACCCCCC"], 3 },
        };
}
