using LeetCode.P01047RemoveAllAdjacentDuplicatesInString.Stack;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01047RemoveAllAdjacentDuplicatesInString.SolutionTestCases;

namespace LeetCode.Tests.P01047RemoveAllAdjacentDuplicatesInString.Stack;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.RemoveDuplicatesCases), MemberType = typeof(RootSolutionTestCases))]
    public void RemoveDuplicates_ReturnsStringAfterRemovingAdjacentDuplicates(string s, string expected)
    {
        Solution solution = new();

        string actual = solution.RemoveDuplicates(s);

        Assert.Equal(expected, actual);
    }
}
