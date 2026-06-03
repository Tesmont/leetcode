using LeetCode.P01544MakeTheStringGreat;
using Xunit;

namespace LeetCode.Tests.P01544MakeTheStringGreat;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.MakeGoodCases), MemberType = typeof(SolutionTestCases))]
    public void MakeGood_ReturnsGoodString(string s, string expected)
    {
        Solution solution = new();

        string actual = solution.MakeGood(s);

        Assert.Equal(expected, actual);
    }
}
