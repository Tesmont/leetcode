using LeetCode.P00907SumOfSubarrayMinimums.ThreePasses;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00907SumOfSubarrayMinimums.SolutionTestCases;

namespace LeetCode.Tests.P00907SumOfSubarrayMinimums.ThreePasses;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.SumSubarrayMinsCases), MemberType = typeof(RootSolutionTestCases))]
    public void SumSubarrayMins_ReturnsSumOfSubarrayMinimums(int[] arr, int expected)
    {
        Solution solution = new();

        int actual = solution.SumSubarrayMins(arr);

        Assert.Equal(expected, actual);
    }
}
