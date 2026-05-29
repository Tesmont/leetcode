using LeetCode.P01732FindTheHighestAltitude;
using Xunit;

namespace LeetCode.Tests.P01732FindTheHighestAltitude;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.LargestAltitudeCases), MemberType = typeof(SolutionTestCases))]
    public void LargestAltitude_ReturnsExpectedHighestAltitude(int[] gain, int expected)
    {
        Solution solution = new();

        int actual = solution.LargestAltitude(gain);

        Assert.Equal(expected, actual);
    }
}
