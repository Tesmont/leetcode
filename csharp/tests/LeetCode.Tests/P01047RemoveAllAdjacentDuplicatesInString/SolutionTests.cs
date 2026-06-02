using LeetCode.P01047RemoveAllAdjacentDuplicatesInString;
using Xunit;

namespace LeetCode.Tests.P01047RemoveAllAdjacentDuplicatesInString;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.RemoveDuplicatesCases), MemberType = typeof(SolutionTestCases))]
    public void RemoveDuplicates_ReturnsStringAfterRemovingAdjacentDuplicates(string s, string expected)
    {
        Solution solution = new();

        string actual = solution.RemoveDuplicates(s);

        Assert.Equal(expected, actual);
    }
}
