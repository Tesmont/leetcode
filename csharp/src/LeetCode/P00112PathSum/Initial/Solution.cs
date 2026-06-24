namespace LeetCode.P00112PathSum.Initial;

/// <summary>
/// LeetCode 112. Path Sum.
/// https://leetcode.com/problems/path-sum/
/// </summary>
public sealed class Solution
{
    public bool HasPathSum(TreeNode? root, int targetSum)
    {
        if (root == null)
        {
            return false;
        }

        targetSum -= root.val;
        if (root.left == null && root.right == null)
        {
            return targetSum == 0;
        }

        bool leftResult = HasPathSum(root.left, targetSum);
        bool rightResult = HasPathSum(root.right, targetSum);

        return leftResult | rightResult;
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
