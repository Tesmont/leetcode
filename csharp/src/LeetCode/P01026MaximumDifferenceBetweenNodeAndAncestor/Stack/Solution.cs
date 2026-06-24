namespace LeetCode.P01026MaximumDifferenceBetweenNodeAndAncestor.Stack;

/// <summary>
/// LeetCode 1026. Maximum Difference Between Node and Ancestor.
/// https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/
/// </summary>
public sealed class Solution
{
    public int MaxAncestorDiff(TreeNode root)
    {
        Stack<(TreeNode Node, int MinValue, int MaxValue)> stack = new();
        stack.Push((root, root.val, root.val));
        int maxDifference = 0;

        while (stack.TryPop(out (TreeNode Node, int MinValue, int MaxValue) current))
        {
            int minValue = Math.Min(current.MinValue, current.Node.val);
            int maxValue = Math.Max(current.MaxValue, current.Node.val);
            maxDifference = Math.Max(maxDifference, maxValue - minValue);

            if (current.Node.left != null)
            {
                stack.Push((current.Node.left, minValue, maxValue));
            }

            if (current.Node.right != null)
            {
                stack.Push((current.Node.right, minValue, maxValue));
            }
        }

        return maxDifference;
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
