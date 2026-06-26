namespace LeetCode.P00530MinimumAbsoluteDifferenceInBST.Initial;

/// <summary>
/// LeetCode 530. Minimum Absolute Difference in BST.
/// https://leetcode.com/problems/minimum-absolute-difference-in-bst/
/// </summary>
public sealed class Solution
{
    public int GetMinimumDifference(TreeNode root)
    {
        int minimumDifference = int.MaxValue;
        int? previousValue = null;

        Dfs(root);

        return minimumDifference;

        void Dfs(TreeNode? node)
        {
            if (node == null)
            {
                return;
            }

            Dfs(node.left);

            if (previousValue.HasValue)
            {
                int difference = node.val - previousValue.Value;
                minimumDifference = Math.Min(minimumDifference, difference);
            }

            previousValue = node.val;

            Dfs(node.right);
        }

    }
}

public sealed class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
