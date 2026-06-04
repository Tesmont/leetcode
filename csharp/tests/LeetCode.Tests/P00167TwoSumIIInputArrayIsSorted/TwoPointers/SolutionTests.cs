using LeetCode.P00167TwoSumIIInputArrayIsSorted.TwoPointers;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00167TwoSumIIInputArrayIsSorted.SolutionTestCases;

namespace LeetCode.Tests.P00167TwoSumIIInputArrayIsSorted.TwoPointers;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.TwoSumCases), MemberType = typeof(RootSolutionTestCases))]
    public void TwoSum_ReturnsOneBasedIndicesOfNumbersAddingToTarget(int[] numbers, int target, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.TwoSum(numbers, target);

        Assert.Equal(expected, actual);
    }
}
