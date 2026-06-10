using LeetCode.P00735AsteroidCollision.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00735AsteroidCollision.SolutionTestCases;

namespace LeetCode.Tests.P00735AsteroidCollision.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.AsteroidCollisionCases), MemberType = typeof(RootSolutionTestCases))]
    public void AsteroidCollision_ReturnsRemainingAsteroids(int[] asteroids, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.AsteroidCollision(asteroids);

        Assert.Equal(expected, actual);
    }
}
