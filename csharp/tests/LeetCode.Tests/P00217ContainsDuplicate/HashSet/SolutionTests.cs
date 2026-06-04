using LeetCode.P00217ContainsDuplicate.HashSet;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00217ContainsDuplicate.SolutionTestCases;

namespace LeetCode.Tests.P00217ContainsDuplicate.HashSet;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.ContainsDuplicateCases), MemberType = typeof(RootSolutionTestCases))]
    public void ContainsDuplicate_ReturnsWhetherAnyValueAppearsAtLeastTwice(int[] nums, bool expected)
    {
        Solution solution = new();

        bool actual = solution.ContainsDuplicate(nums);

        Assert.Equal(expected, actual);
    }
}
