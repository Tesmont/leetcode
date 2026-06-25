namespace LeetCode.P00543DiameterOfBinaryTree.RecursiveDFS;

/// <summary>
/// LeetCode 543. Diameter of Binary Tree.
/// https://leetcode.com/problems/diameter-of-binary-tree/
/// </summary>
public sealed class Solution
{
    public int DiameterOfBinaryTree(TreeNode root)
    {
        int maxDiameter = 0;

        GetHeight(root);

        return maxDiameter;

        int GetHeight(TreeNode? node)
        {
            if (node == null)
            {
                return -1;
            }

            int leftHeight = GetHeight(node.left);
            int rightHeight = GetHeight(node.right);

            int diameter = leftHeight + rightHeight + 2;
            maxDiameter = Math.Max(maxDiameter, diameter);

            return Math.Max(leftHeight, rightHeight) + 1;
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
