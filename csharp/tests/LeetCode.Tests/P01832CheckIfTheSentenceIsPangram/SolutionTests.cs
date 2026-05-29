using LeetCode.P01832CheckIfTheSentenceIsPangram;
using Xunit;

namespace LeetCode.Tests.P01832CheckIfTheSentenceIsPangram;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.CheckIfPangramCases), MemberType = typeof(SolutionTestCases))]
    public void CheckIfPangram_ReturnsExpectedResult(string sentence, bool expected)
    {
        Solution solution = new();

        bool actual = solution.CheckIfPangram(sentence);

        Assert.Equal(expected, actual);
    }
}
