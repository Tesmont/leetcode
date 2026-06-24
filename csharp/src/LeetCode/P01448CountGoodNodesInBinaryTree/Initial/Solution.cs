namespace LeetCode.P01448CountGoodNodesInBinaryTree.Initial;

/// <summary>
/// LeetCode 1448. Count Good Nodes in Binary Tree.
/// https://leetcode.com/problems/count-good-nodes-in-binary-tree/
/// </summary>
public sealed class Solution
{
    public int GoodNodes(TreeNode root)
    {
        return DFS(root, int.MinValue);
    }

    public int DFS(TreeNode? root, int maxValue)
    {
        if (root == null)
        {
            return 0;
        }

        int result;
        if (root.val >= maxValue)
        {
            result = 1;
            maxValue = root.val;
        }
        else
        {
            result = 0;
        }

        result += DFS(root.left, maxValue);
        result += DFS(root.right, maxValue);

        return result;
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
