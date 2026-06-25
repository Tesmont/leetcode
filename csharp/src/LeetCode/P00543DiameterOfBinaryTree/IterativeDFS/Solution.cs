namespace LeetCode.P00543DiameterOfBinaryTree.IterativeDFS;

/// <summary>
/// LeetCode 543. Diameter of Binary Tree.
/// https://leetcode.com/problems/diameter-of-binary-tree/
/// </summary>
public sealed class Solution
{
    public int DiameterOfBinaryTree(TreeNode root)
    {
        Stack<TreeNode> stack = new();
        Dictionary<TreeNode, int> heights = new();

        TreeNode? current = root;
        TreeNode? lastVisited = null;

        int maxDiameter = 0;

        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            TreeNode peek = stack.Peek();

            bool shouldVisitRightSubtree =
                peek.right != null &&
                peek.right != lastVisited;

            if (shouldVisitRightSubtree)
            {
                current = peek.right;
            }
            else
            {
                int leftHeight = peek.left == null
                    ? -1
                    : heights[peek.left];
                int rightHeight = peek.right == null
                    ? -1
                    : heights[peek.right];
                int diameter = leftHeight + rightHeight + 2;
                maxDiameter = Math.Max(maxDiameter, diameter);
                heights[peek] = Math.Max(leftHeight, rightHeight) + 1;

                lastVisited = stack.Pop();
            }
        }

        return maxDiameter;
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
