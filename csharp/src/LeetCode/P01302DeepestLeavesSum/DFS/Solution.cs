namespace LeetCode.P01302DeepestLeavesSum.DFS;

/// <summary>
/// LeetCode 1302. Deepest Leaves Sum.
/// https://leetcode.com/problems/deepest-leaves-sum/
/// </summary>
public sealed class Solution
{
    public int DeepestLeavesSum(TreeNode root)
    {
        int sum = 0;
        int maxLevel = 0;

        Dfs(root, 0);

        return sum;

        void Dfs(TreeNode? node, int level)
        {
            if (node == null)
            {
                return;
            }

            if (level > maxLevel)
            {
                sum = node.val;
                maxLevel = level;
            }
            else if (level == maxLevel)
            {
                sum += node.val;
            }

            level++;
            Dfs(node.left, level);
            Dfs(node.right, level);
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
