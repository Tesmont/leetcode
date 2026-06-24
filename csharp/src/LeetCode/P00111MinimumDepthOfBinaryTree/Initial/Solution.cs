namespace LeetCode.P00111MinimumDepthOfBinaryTree.Initial;

/// <summary>
/// LeetCode 111. Minimum Depth of Binary Tree.
/// https://leetcode.com/problems/minimum-depth-of-binary-tree/
/// </summary>
public sealed class Solution
{
    public int MinDepth(TreeNode? root)
    {
        throw new System.NotImplementedException();
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
