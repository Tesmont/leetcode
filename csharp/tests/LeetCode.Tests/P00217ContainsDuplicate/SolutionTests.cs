using LeetCode.P00217ContainsDuplicate;
using Xunit;

namespace LeetCode.Tests.P00217ContainsDuplicate;

public sealed class SolutionTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    [InlineData(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public void ContainsDuplicate_ReturnsWhetherAnyValueAppearsAtLeastTwice(int[] nums, bool expected)
    {
        Solution solution = new();

        bool actual = solution.ContainsDuplicate(nums);

        Assert.Equal(expected, actual);
    }
}
