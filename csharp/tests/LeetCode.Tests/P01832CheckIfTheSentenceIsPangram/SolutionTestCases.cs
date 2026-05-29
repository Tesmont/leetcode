using Xunit;

namespace LeetCode.Tests.P01832CheckIfTheSentenceIsPangram;

public static class SolutionTestCases
{
    public static TheoryData<string, bool> CheckIfPangramCases =>
        new()
        {
            { "thequickbrownfoxjumpsoverthelazydog", true },
            { "leetcode", false },
        };
}
