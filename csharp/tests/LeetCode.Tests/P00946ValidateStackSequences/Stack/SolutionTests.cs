using LeetCode.P00946ValidateStackSequences.Stack;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00946ValidateStackSequences.SolutionTestCases;

namespace LeetCode.Tests.P00946ValidateStackSequences.Stack;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.ValidateStackSequencesCases), MemberType = typeof(RootSolutionTestCases))]
    public void ValidateStackSequences_ReturnsWhetherSequencesAreValid(int[] pushed, int[] popped, bool expected)
    {
        Solution solution = new();

        bool actual = solution.ValidateStackSequences(pushed, popped);

        Assert.Equal(expected, actual);
    }
}
