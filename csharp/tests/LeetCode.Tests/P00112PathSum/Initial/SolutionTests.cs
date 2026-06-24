using LeetCode.P00112PathSum.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00112PathSum.SolutionTestCases;

namespace LeetCode.Tests.P00112PathSum.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.HasPathSumCases), MemberType = typeof(RootSolutionTestCases))]
    public void HasPathSum_ReturnsWhetherRootToLeafPathMatchesTarget(int?[] values, int targetSum, bool expected)
    {
        Solution solution = new();
        TreeNode? root = BuildTree(values);

        bool actual = solution.HasPathSum(root, targetSum);

        Assert.Equal(expected, actual);
    }

    private static TreeNode? BuildTree(int?[] values)
    {
        int? rootValue = values.Length == 0 ? null : values[0];

        if (rootValue == null)
        {
            return null;
        }

        TreeNode root = new(rootValue.Value);
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int index = 1;

        while (queue.Count > 0 && index < values.Length)
        {
            TreeNode current = queue.Dequeue();

            int? leftValue = index < values.Length ? values[index] : null;
            if (leftValue != null)
            {
                current.left = new TreeNode(leftValue.Value);
                queue.Enqueue(current.left);
            }

            index++;

            int? rightValue = index < values.Length ? values[index] : null;
            if (rightValue != null)
            {
                current.right = new TreeNode(rightValue.Value);
                queue.Enqueue(current.right);
            }

            index++;
        }

        return root;
    }
}
