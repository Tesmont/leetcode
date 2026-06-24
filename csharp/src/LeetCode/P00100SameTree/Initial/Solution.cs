namespace LeetCode.P00100SameTree.Initial;

/// <summary>
/// LeetCode 100. Same Tree.
/// https://leetcode.com/problems/same-tree/
/// </summary>
public sealed class Solution
{
    public bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        if (p == null || q == null)
        {
            return p == q;
        }

        return p.val == q.val
            && IsSameTree(p.left, q.left)
            && IsSameTree(p.right, q.right);
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
