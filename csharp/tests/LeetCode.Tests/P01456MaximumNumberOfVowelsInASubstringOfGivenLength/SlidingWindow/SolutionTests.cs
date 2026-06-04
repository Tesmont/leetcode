using LeetCode.P01456MaximumNumberOfVowelsInASubstringOfGivenLength.SlidingWindow;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01456MaximumNumberOfVowelsInASubstringOfGivenLength.SolutionTestCases;

namespace LeetCode.Tests.P01456MaximumNumberOfVowelsInASubstringOfGivenLength.SlidingWindow;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MaxVowelsCases), MemberType = typeof(RootSolutionTestCases))]
    public void MaxVowels_ReturnsExpectedMaximum(string s, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxVowels(s, k);

        Assert.Equal(expected, actual);
    }
}
