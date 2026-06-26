namespace LeetCode.P00938RangeSumOfBST.Initial;

/// <summary>
/// LeetCode 938. Range Sum of BST.
/// https://leetcode.com/problems/range-sum-of-bst/
/// </summary>
public sealed class Solution
{
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        return Dfs(root);

        int Dfs(TreeNode? node)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.val < low)
            {
                return Dfs(node.right);
            }

            if (node.val > high)
            {
                return Dfs(node.left);
            }

            int leftSum = Dfs(node.left);
            int righSum = Dfs(node.right);

            return leftSum + righSum + node.val;
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
