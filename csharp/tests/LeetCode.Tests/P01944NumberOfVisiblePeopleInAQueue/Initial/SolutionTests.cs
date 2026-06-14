using LeetCode.P01944NumberOfVisiblePeopleInAQueue.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01944NumberOfVisiblePeopleInAQueue.SolutionTestCases;

namespace LeetCode.Tests.P01944NumberOfVisiblePeopleInAQueue.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.CanSeePersonsCountCases), MemberType = typeof(RootSolutionTestCases))]
    public void CanSeePersonsCount_ReturnsVisiblePeopleCounts(int[] heights, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.CanSeePersonsCount(heights);

        Assert.Equal(expected, actual);
    }
}
