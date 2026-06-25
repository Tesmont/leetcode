namespace LeetCode.P01302DeepestLeavesSum.BFS;

/// <summary>
/// LeetCode 1302. Deepest Leaves Sum.
/// https://leetcode.com/problems/deepest-leaves-sum/
/// </summary>
public sealed class Solution
{
    public int DeepestLeavesSum(TreeNode root)
    {
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        int sum = 0;

        while (queue.Count > 0)
        {
            int levelCount = queue.Count;
            sum = 0;

            for (int i = 0; i < levelCount; i++)
            {
                TreeNode current = queue.Dequeue();

                sum += current.val;

                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }

                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }
        }

        return sum;
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
