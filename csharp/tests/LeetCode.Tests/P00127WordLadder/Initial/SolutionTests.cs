using LeetCode.P00127WordLadder.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00127WordLadder.SolutionTestCases;

namespace LeetCode.Tests.P00127WordLadder.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.LadderLengthCases), MemberType = typeof(RootSolutionTestCases))]
    public void LadderLength_ReturnsShortestTransformationSequenceLength(
        string beginWord,
        string endWord,
        IList<string> wordList,
        int expected)
    {
        Solution solution = new();

        int actual = solution.LadderLength(beginWord, endWord, wordList);

        Assert.Equal(expected, actual);
    }
}
