using Xunit;

namespace LeetCode.Tests.P01456MaximumNumberOfVowelsInASubstringOfGivenLength;

public static class SolutionTestCases
{
    public static TheoryData<string, int, int> MaxVowelsCases =>
        new()
        {
            { "abciiidef", 3, 3 },
            { "aeiou", 2, 2 },
            { "leetcode", 3, 2 },
            { "rhythms", 4, 0 },
            { "tryhard", 4, 1 },
            { "zpuerktejfp", 3, 2 }
        };
}
