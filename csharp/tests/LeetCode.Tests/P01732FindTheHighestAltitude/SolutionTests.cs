using LeetCode.P01732FindTheHighestAltitude;
using Xunit;

namespace LeetCode.Tests.P01732FindTheHighestAltitude;

public sealed class SolutionTests
{
    public static TheoryData<int[], int> LargestAltitudeCases =>
        new()
        {
            { [-5, 1, 5, 0, -7], 1 },
            { [-4, -3, -2, -1, 4, 3, 2], 0 },
        };

    [Theory]
    [MemberData(nameof(LargestAltitudeCases))]
    public void LargestAltitude_ReturnsExpectedHighestAltitude(int[] gain, int expected)
    {
        Solution solution = new();

        int actual = solution.LargestAltitude(gain);

        Assert.Equal(expected, actual);
    }
}
