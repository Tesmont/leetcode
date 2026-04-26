using LeetCode.P00167TwoSumIIInputArrayIsSorted.BinarySearch;
using Xunit;

namespace LeetCode.Tests.P00167TwoSumIIInputArrayIsSorted.BinarySearch;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.TwoSumCases), MemberType = typeof(SolutionTestCases))]
    public void TwoSum_ReturnsOneBasedIndicesOfNumbersAddingToTarget(int[] numbers, int target, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.TwoSum(numbers, target);

        Assert.Equal(expected, actual);
    }
}
