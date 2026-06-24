namespace LeetCode.P00236LowestCommonAncestorOfABinaryTree.Initial;

/// <summary>
/// LeetCode 236. Lowest Common Ancestor of a Binary Tree.
/// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
/// </summary>
public sealed class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        return FindLowestCommonAncestor(root, p, q)!;
    }

    private static TreeNode? FindLowestCommonAncestor(TreeNode? root, TreeNode p, TreeNode q)
    {
        if (root == null)
        {
            return null;
        }

        if (root == p || root == q)
        {
            return root;
        }

        TreeNode? left = FindLowestCommonAncestor(root.left, p, q);
        TreeNode? right = FindLowestCommonAncestor(root.right, p, q);

        if (left != null && right != null)
        {
            return root;
        }

        return left ?? right;
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
