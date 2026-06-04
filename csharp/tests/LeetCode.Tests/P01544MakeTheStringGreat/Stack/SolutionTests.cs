using LeetCode.P01544MakeTheStringGreat.Stack;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01544MakeTheStringGreat.SolutionTestCases;

namespace LeetCode.Tests.P01544MakeTheStringGreat.Stack;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MakeGoodCases), MemberType = typeof(RootSolutionTestCases))]
    public void MakeGood_ReturnsGoodString(string s, string expected)
    {
        Solution solution = new();

        string actual = solution.MakeGood(s);

        Assert.Equal(expected, actual);
    }
}
