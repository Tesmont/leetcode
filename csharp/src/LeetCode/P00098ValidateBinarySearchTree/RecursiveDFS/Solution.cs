namespace LeetCode.P00098ValidateBinarySearchTree.RecursiveDFS;

/// <summary>
/// LeetCode 98. Validate Binary Search Tree.
/// https://leetcode.com/problems/validate-binary-search-tree/
/// </summary>
public sealed class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        long previousValue = long.MinValue;

        return Dfs(root);

        bool Dfs(TreeNode? node)
        {
            if (node == null)
            {
                return true;
            }

            if (!Dfs(node.left))
            {
                return false;
            }

            if (node.val <= previousValue)
            {
                return false;
            }

            previousValue = node.val;

            return Dfs(node.right);
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
