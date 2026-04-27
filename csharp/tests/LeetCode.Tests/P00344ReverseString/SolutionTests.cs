using LeetCode.P00344ReverseString;
using Xunit;

namespace LeetCode.Tests.P00344ReverseString;

public sealed class SolutionTests
{
    public static TheoryData<char[], char[]> ReverseStringCases =>
        new()
        {
            { ['h', 'e', 'l', 'l', 'o'], ['o', 'l', 'l', 'e', 'h'] },
            { ['H', 'a', 'n', 'n', 'a', 'h'], ['h', 'a', 'n', 'n', 'a', 'H'] },
            { ['a'], ['a'] },
            { ['a', 'b'], ['b', 'a'] },
        };

    [Theory]
    [MemberData(nameof(ReverseStringCases))]
    public void ReverseString_ReversesArrayInPlace(char[] s, char[] expected)
    {
        Solution solution = new();

        solution.ReverseString(s);

        Assert.Equal(expected, s);
    }
}
