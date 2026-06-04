using LeetCode.P00346MovingAverageFromDataStream.Queue;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00346MovingAverageFromDataStream.SolutionTestCases;

namespace LeetCode.Tests.P00346MovingAverageFromDataStream.Queue;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.NextCases), MemberType = typeof(RootSolutionTestCases))]
    public void Next_ReturnsMovingAverage(int size, int[] values, double[] expected)
    {
        MovingAverage movingAverage = new(size);
        double[] actual = new double[values.Length];

        for (int i = 0; i < values.Length; i++)
        {
            actual[i] = movingAverage.Next(values[i]);
        }

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], actual[i], precision: 5);
        }
    }
}
