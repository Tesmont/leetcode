using LeetCode.P00863AllNodesDistanceKInBinaryTree.ParentMapBFS;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00863AllNodesDistanceKInBinaryTree.SolutionTestCases;

namespace LeetCode.Tests.P00863AllNodesDistanceKInBinaryTree.ParentMapBFS;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.DistanceKCases), MemberType = typeof(RootSolutionTestCases))]
    public void DistanceK_ReturnsValuesAtSpecifiedDistance(
        int?[] values,
        int targetValue,
        int k,
        int[] expected)
    {
        Solution solution = new();
        TreeNode root = BuildTree(values);
        TreeNode target = FindNode(root, targetValue);

        IList<int> actual = solution.DistanceK(root, target, k);

        Assert.Equal(expected.OrderBy(value => value), actual.OrderBy(value => value));
    }

    private static TreeNode BuildTree(int?[] values)
    {
        int? rootValue = values.Length == 0 ? null : values[0];

        if (rootValue == null)
        {
            throw new System.ArgumentException("Tree must have a root node.", nameof(values));
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

    private static TreeNode FindNode(TreeNode root, int value)
    {
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();

            if (current.val == value)
            {
                return current;
            }

            if (current.left != null)
            {
                queue.Enqueue(current.left);
            }

            if (current.right != null)
            {
                queue.Enqueue(current.right);
            }
        }

        throw new System.ArgumentException("Node value was not found in the tree.", nameof(value));
    }
}
