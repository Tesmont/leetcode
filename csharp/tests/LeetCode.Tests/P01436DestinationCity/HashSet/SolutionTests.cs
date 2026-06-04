using LeetCode.P01436DestinationCity.HashSet;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01436DestinationCity.SolutionTestCases;

namespace LeetCode.Tests.P01436DestinationCity.HashSet;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.DestCityCases), MemberType = typeof(RootSolutionTestCases))]
    public void DestCity_ReturnsDestinationCity(IList<IList<string>> paths, string expected)
    {
        Solution solution = new();

        string actual = solution.DestCity(paths);

        Assert.Equal(expected, actual);
    }
}
