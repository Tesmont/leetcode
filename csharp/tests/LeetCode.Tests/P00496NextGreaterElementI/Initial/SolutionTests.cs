using LeetCode.P00496NextGreaterElementI.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00496NextGreaterElementI.SolutionTestCases;

namespace LeetCode.Tests.P00496NextGreaterElementI.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.NextGreaterElementCases), MemberType = typeof(RootSolutionTestCases))]
    public void NextGreaterElement_ReturnsNextGreaterValues(int[] nums1, int[] nums2, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.NextGreaterElement(nums1, nums2);

        Assert.Equal(expected, actual);
    }
}
