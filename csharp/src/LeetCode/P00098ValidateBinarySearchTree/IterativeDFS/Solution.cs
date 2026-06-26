namespace LeetCode.P00098ValidateBinarySearchTree.IterativeDFS;

/// <summary>
/// LeetCode 98. Validate Binary Search Tree.
/// https://leetcode.com/problems/validate-binary-search-tree/
/// </summary>
public sealed class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        Stack<TreeNode> stack = new();
        TreeNode? current = root;
        long previousValue = long.MinValue;

        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            TreeNode node = stack.Pop();
            if (node.val <= previousValue)
            {
                return false;
            }

            previousValue = node.val;
            current = node.right;
        }

        return true;
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
