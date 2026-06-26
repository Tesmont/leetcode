using LeetCode.P00701InsertIntoABinarySearchTree.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00701InsertIntoABinarySearchTree.SolutionTestCases;

namespace LeetCode.Tests.P00701InsertIntoABinarySearchTree.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.InsertIntoBSTCases), MemberType = typeof(RootSolutionTestCases))]
    public void InsertIntoBST_ReturnsTreeWithValueInserted(int?[] values, int val, int?[] expected)
    {
        Solution solution = new();
        TreeNode? root = BuildTree(values);

        TreeNode? actual = solution.InsertIntoBST(root, val);

        Assert.Equal(expected, ToLevelOrder(actual));
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

    private static int?[] ToLevelOrder(TreeNode? root)
    {
        if (root == null)
        {
            return [];
        }

        List<int?> values = [];
        Queue<TreeNode?> queue = new();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode? current = queue.Dequeue();
            values.Add(current?.val);

            if (current != null)
            {
                queue.Enqueue(current.left);
                queue.Enqueue(current.right);
            }
        }

        while (values.Count > 0 && values[^1] == null)
        {
            values.RemoveAt(values.Count - 1);
        }

        return [.. values];
    }
}
