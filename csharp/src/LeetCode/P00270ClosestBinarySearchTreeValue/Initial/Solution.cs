namespace LeetCode.P00270ClosestBinarySearchTreeValue.Initial;

/// <summary>
/// LeetCode 270. Closest Binary Search Tree Value.
/// https://leetcode.com/problems/closest-binary-search-tree-value/
/// </summary>
public sealed class Solution
{
    public int ClosestValue(TreeNode root, double target)
    {
        int closestValue = root.val;
        double minimalDifference = double.PositiveInfinity;

        TreeNode? currentNode = root;

        while (currentNode != null)
        {
            double difference = Math.Abs(currentNode.val - target);

            if (difference < minimalDifference)
            {
                closestValue = currentNode.val;
                minimalDifference = difference;
            }
            else if (difference == minimalDifference
                && closestValue > currentNode.val)
            {
                closestValue = currentNode.val;
            }

            if (target < currentNode.val)
            {
                currentNode = currentNode.left;
            }
            else if (target > currentNode.val)
            {
                currentNode = currentNode.right;
            }
            else
            {
                return currentNode.val;
            }
        }

        return closestValue;
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
