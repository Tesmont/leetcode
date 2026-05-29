using LeetCode.P01436DestinationCity;
using Xunit;

namespace LeetCode.Tests.P01436DestinationCity;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.DestCityCases), MemberType = typeof(SolutionTestCases))]
    public void DestCity_ReturnsDestinationCity(IList<IList<string>> paths, string expected)
    {
        Solution solution = new();

        string actual = solution.DestCity(paths);

        Assert.Equal(expected, actual);
    }
}
