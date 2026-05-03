using LeetCode.P01456MaximumNumberOfVowelsInASubstringOfGivenLength;
using Xunit;

namespace LeetCode.Tests.P01456MaximumNumberOfVowelsInASubstringOfGivenLength;

public sealed class SolutionTests
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

    [Theory]
    [MemberData(nameof(MaxVowelsCases))]
    public void MaxVowels_ReturnsExpectedMaximum(string s, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxVowels(s, k);

        Assert.Equal(expected, actual);
    }
}
