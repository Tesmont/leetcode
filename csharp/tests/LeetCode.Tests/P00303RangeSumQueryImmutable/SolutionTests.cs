using LeetCode.P00303RangeSumQueryImmutable;
using Xunit;

namespace LeetCode.Tests.P00303RangeSumQueryImmutable;

public sealed class SolutionTests
{
    [Fact]
    public void SumRange_ReturnsExpectedSums()
    {
        NumArray numArray = new([-2, 0, 3, -5, 2, -1]);

        Assert.Equal(1, numArray.SumRange(0, 2));
        Assert.Equal(-1, numArray.SumRange(2, 5));
        Assert.Equal(-3, numArray.SumRange(0, 5));
    }
}
