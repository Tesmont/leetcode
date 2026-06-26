using LeetCode.P00098ValidateBinarySearchTree.RecursiveDFS;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00098ValidateBinarySearchTree.SolutionTestCases;

namespace LeetCode.Tests.P00098ValidateBinarySearchTree.RecursiveDFS;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.IsValidBSTCases), MemberType = typeof(RootSolutionTestCases))]
    public void IsValidBST_ReturnsWhetherTreeSatisfiesStrictBstOrdering(int?[] values, bool expected)
    {
        Solution solution = new();
        TreeNode root = BuildTree(values)!;

        bool actual = solution.IsValidBST(root);

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
