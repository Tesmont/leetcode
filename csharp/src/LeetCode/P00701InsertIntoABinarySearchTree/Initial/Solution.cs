namespace LeetCode.P00701InsertIntoABinarySearchTree.Initial;

/// <summary>
/// LeetCode 701. Insert into a Binary Search Tree.
/// https://leetcode.com/problems/insert-into-a-binary-search-tree/
/// </summary>
public sealed class Solution
{
    public TreeNode InsertIntoBST(TreeNode? root, int val)
    {
        if (root == null)
        {
            return new TreeNode(val);
        }

        TreeNode current = root;

        while (true)
        {
            if (val < current.val)
            {
                if (current.left == null)
                {
                    current.left = new TreeNode(val);
                    return root;
                }

                current = current.left;
            }
            else
            {
                if (current.right == null)
                {
                    current.right = new TreeNode(val);
                    return root;
                }

                current = current.right;
            }
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
