using LeetCode.P01456MaximumNumberOfVowelsInASubstringOfGivenLength;
using Xunit;

namespace LeetCode.Tests.P01456MaximumNumberOfVowelsInASubstringOfGivenLength;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.MaxVowelsCases), MemberType = typeof(SolutionTestCases))]
    public void MaxVowels_ReturnsExpectedMaximum(string s, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxVowels(s, k);

        Assert.Equal(expected, actual);
    }
}
