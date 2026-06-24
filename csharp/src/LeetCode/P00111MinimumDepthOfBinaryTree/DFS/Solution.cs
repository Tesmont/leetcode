namespace LeetCode.P00111MinimumDepthOfBinaryTree.DFS;

/// <summary>
/// LeetCode 111. Minimum Depth of Binary Tree.
/// https://leetcode.com/problems/minimum-depth-of-binary-tree/
/// </summary>
public sealed class Solution
{
    public int MinDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        return DFS(root);
    }

    private int DFS(TreeNode root)
    {
        if (root.left == null)
        {
            if (root.right == null)
            {
                return 1;
            }

            return DFS(root.right) + 1;
        }

        if (root.right == null)
        {
            return DFS(root.left) + 1;
        }

        int leftMinDepth = DFS(root.left);
        int rightMinDepth = DFS(root.right);

        return Math.Min(leftMinDepth, rightMinDepth) + 1;
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
