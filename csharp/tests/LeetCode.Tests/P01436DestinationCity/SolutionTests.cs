using LeetCode.P01436DestinationCity;
using Xunit;

namespace LeetCode.Tests.P01436DestinationCity;

public sealed class SolutionTests
{
    public static TheoryData<IList<IList<string>>, string> DestCityCases =>
        new()
        {
            {
                new List<IList<string>>
                {
                    new List<string> { "London", "New York" },
                    new List<string> { "New York", "Lima" },
                    new List<string> { "Lima", "Sao Paulo" },
                },
                "Sao Paulo"
            },
            {
                new List<IList<string>>
                {
                    new List<string> { "B", "C" },
                    new List<string> { "D", "B" },
                    new List<string> { "C", "A" },
                },
                "A"
            },
            {
                new List<IList<string>>
                {
                    new List<string> { "A", "Z" },
                },
                "Z"
            },
        };

    [Theory]
    [MemberData(nameof(DestCityCases))]
    public void DestCity_ReturnsDestinationCity(IList<IList<string>> paths, string expected)
    {
        Solution solution = new();

        string actual = solution.DestCity(paths);

        Assert.Equal(expected, actual);
    }
}
