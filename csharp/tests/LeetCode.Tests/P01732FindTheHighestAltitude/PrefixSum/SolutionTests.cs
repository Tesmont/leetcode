using LeetCode.P01732FindTheHighestAltitude.PrefixSum;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01732FindTheHighestAltitude.SolutionTestCases;

namespace LeetCode.Tests.P01732FindTheHighestAltitude.PrefixSum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.LargestAltitudeCases), MemberType = typeof(RootSolutionTestCases))]
    public void LargestAltitude_ReturnsExpectedHighestAltitude(int[] gain, int expected)
    {
        Solution solution = new();

        int actual = solution.LargestAltitude(gain);

        Assert.Equal(expected, actual);
    }
}
