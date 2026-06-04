using LeetCode.P00303RangeSumQueryImmutable.PrefixSum;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00303RangeSumQueryImmutable.SolutionTestCases;

namespace LeetCode.Tests.P00303RangeSumQueryImmutable.PrefixSum;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.SumRangeCases), MemberType = typeof(RootSolutionTestCases))]
    public void SumRange_ReturnsExpectedSums(int[] nums, int[][] ranges, int[] expected)
    {
        NumArray numArray = new(nums);

        for (int i = 0; i < ranges.Length; i++)
        {
            Assert.Equal(expected[i], numArray.SumRange(ranges[i][0], ranges[i][1]));
        }
    }
}
