using LeetCode.P00100SameTree.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00100SameTree.SolutionTestCases;

namespace LeetCode.Tests.P00100SameTree.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.IsSameTreeCases), MemberType = typeof(RootSolutionTestCases))]
    public void IsSameTree_ReturnsWhetherTreesAreStructurallyIdentical(int?[] pValues, int?[] qValues, bool expected)
    {
        Solution solution = new();
        TreeNode? p = BuildTree(pValues);
        TreeNode? q = BuildTree(qValues);

        bool actual = solution.IsSameTree(p, q);

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
