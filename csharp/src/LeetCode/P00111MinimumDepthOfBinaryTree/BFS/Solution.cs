namespace LeetCode.P00111MinimumDepthOfBinaryTree.BFS;

/// <summary>
/// LeetCode 111. Minimum Depth of Binary Tree.
/// https://leetcode.com/problems/minimum-depth-of-binary-tree/
/// </summary>
public sealed class Solution
{
    public int MinDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int rowCount = 1;
        int minDepth = 1;

        while (queue.TryDequeue(out root))
        {
            rowCount--;
            if (root.left == null && root.right == null)
            {
                return minDepth;
            }

            if (root.left != null)
            {
                queue.Enqueue(root.left);
            }

            if (root.right != null)
            {
                queue.Enqueue(root.right);
            }

            if (rowCount == 0)
            {
                rowCount = queue.Count;
                minDepth++;
            }
        }

        return minDepth;
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
