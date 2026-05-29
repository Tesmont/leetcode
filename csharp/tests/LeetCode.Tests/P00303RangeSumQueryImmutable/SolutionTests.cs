using LeetCode.P00303RangeSumQueryImmutable;
using Xunit;

namespace LeetCode.Tests.P00303RangeSumQueryImmutable;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.SumRangeCases), MemberType = typeof(SolutionTestCases))]
    public void SumRange_ReturnsExpectedSums(int[] nums, int[][] ranges, int[] expected)
    {
        NumArray numArray = new(nums);

        for (int i = 0; i < ranges.Length; i++)
        {
            Assert.Equal(expected[i], numArray.SumRange(ranges[i][0], ranges[i][1]));
        }
    }
}
