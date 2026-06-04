using LeetCode.P01832CheckIfTheSentenceIsPangram.HashSet;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01832CheckIfTheSentenceIsPangram.SolutionTestCases;

namespace LeetCode.Tests.P01832CheckIfTheSentenceIsPangram.HashSet;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.CheckIfPangramCases), MemberType = typeof(RootSolutionTestCases))]
    public void CheckIfPangram_ReturnsExpectedResult(string sentence, bool expected)
    {
        Solution solution = new();

        bool actual = solution.CheckIfPangram(sentence);

        Assert.Equal(expected, actual);
    }
}
