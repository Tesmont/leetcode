namespace LeetCode.P01026MaximumDifferenceBetweenNodeAndAncestor.DFS;

/// <summary>
/// LeetCode 1026. Maximum Difference Between Node and Ancestor.
/// https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/
/// </summary>
public sealed class Solution
{
    public int MaxAncestorDiff(TreeNode root)
    {
        return MaxAncestorDiff(root, root.val, root.val);
    }

    private static int MaxAncestorDiff(TreeNode? root, int minValue, int maxValue)
    {
        if (root == null)
        {
            return maxValue - minValue;
        }

        minValue = Math.Min(minValue, root.val);
        maxValue = Math.Max(maxValue, root.val);

        int leftDiff = MaxAncestorDiff(root.left, minValue, maxValue);
        int rightDiff = MaxAncestorDiff(root.right, minValue, maxValue);

        return Math.Max(leftDiff, rightDiff);
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
