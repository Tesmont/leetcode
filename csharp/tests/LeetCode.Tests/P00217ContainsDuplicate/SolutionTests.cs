using LeetCode.P00217ContainsDuplicate;
using Xunit;

namespace LeetCode.Tests.P00217ContainsDuplicate;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.ContainsDuplicateCases), MemberType = typeof(SolutionTestCases))]
    public void ContainsDuplicate_ReturnsWhetherAnyValueAppearsAtLeastTwice(int[] nums, bool expected)
    {
        Solution solution = new();

        bool actual = solution.ContainsDuplicate(nums);

        Assert.Equal(expected, actual);
    }
}
