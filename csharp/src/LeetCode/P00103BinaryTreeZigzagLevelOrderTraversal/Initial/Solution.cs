namespace LeetCode.P00103BinaryTreeZigzagLevelOrderTraversal.Initial;

/// <summary>
/// LeetCode 103. Binary Tree Zigzag Level Order Traversal.
/// https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
/// </summary>
public sealed class Solution
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode? root)
    {
        if (root == null)
        {
            return [];
        }

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        List<IList<int>> result = new();
        int level = 0;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            int[] levelValues = new int[levelSize];
            bool leftToRight = level % 2 == 0;

            for (int i = 0; i < levelSize; i++)
            {
                TreeNode current = queue.Dequeue();

                int index = leftToRight
                    ? i
                    : levelSize - i - 1;

                levelValues[index] = current.val;

                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }

                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }

            result.Add(levelValues);
            level++;
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
