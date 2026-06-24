namespace LeetCode.P00104MaximumDepthOfBinaryTree.Initial;

/// <summary>
/// LeetCode 104. Maximum Depth of Binary Tree.
/// https://leetcode.com/problems/maximum-depth-of-binary-tree/
/// </summary>
public sealed class Solution
{
    public int MaxDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);

        return 1 + Math.Max(leftDepth, rightDepth);
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
