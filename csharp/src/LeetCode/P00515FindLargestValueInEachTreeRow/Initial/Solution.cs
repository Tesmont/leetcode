namespace LeetCode.P00515FindLargestValueInEachTreeRow.Initial;

/// <summary>
/// LeetCode 515. Find Largest Value in Each Tree Row.
/// https://leetcode.com/problems/find-largest-value-in-each-tree-row/
/// </summary>
public sealed class Solution
{
    public IList<int> LargestValues(TreeNode? root)
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
            int levelLength = queue.Count;

            int maxValue = int.MinValue;
            for (int i = 0; i < levelLength; i++)
            {
                TreeNode current = queue.Dequeue();
                maxValue = Math.Max(maxValue, current.val);

                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }

                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }

            result.Add(maxValue);
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
