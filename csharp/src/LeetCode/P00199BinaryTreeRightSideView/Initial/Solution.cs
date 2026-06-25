namespace LeetCode.P00199BinaryTreeRightSideView.Initial;

/// <summary>
/// LeetCode 199. Binary Tree Right Side View.
/// https://leetcode.com/problems/binary-tree-right-side-view/
/// </summary>
public sealed class Solution
{
    public IList<int> RightSideView(TreeNode? root)
    {
        if (root == null)
        {
            return Array.Empty<int>();
        }

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        List<int> result = new();

        while (queue.Count > 0)
        {
            // Nodes are enqueued right-first, so the first node in the queue is visible from the right.
            TreeNode lastNode = queue.Peek();
            result.Add(lastNode.val);

            int levelLength = queue.Count;
            for (int i = 0; i < levelLength; i++)
            {
                TreeNode current = queue.Dequeue();

                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }

                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }
            }
        }

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
