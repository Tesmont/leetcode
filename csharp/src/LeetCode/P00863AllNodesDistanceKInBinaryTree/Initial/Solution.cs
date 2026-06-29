namespace LeetCode.P00863AllNodesDistanceKInBinaryTree.Initial;

/// <summary>
/// LeetCode 863. All Nodes Distance K in Binary Tree.
/// https://leetcode.com/problems/all-nodes-distance-k-in-binary-tree/
/// </summary>
public sealed class Solution
{
    public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
    {
        Dictionary<TreeNode, TreeNode> parents = new();
        BuildParents(root);

        Queue<TreeNode> queue = new();
        HashSet<TreeNode> seen = [target];

        queue.Enqueue(target);
        int distance = 0;

        while (queue.Count > 0 && distance < k)
        {
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++)
            {
                TreeNode node = queue.Dequeue();

                if (node.left != null
                    && seen.Add(node.left))
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null
                    && seen.Add(node.right))
                {
                    queue.Enqueue(node.right);
                }

                if (parents.TryGetValue(node, out TreeNode? parent)
                    && seen.Add(parent))
                {
                    queue.Enqueue(parent);
                }
            }

            distance++;
        }

        List<int> result = new();
        while (queue.TryDequeue(out TreeNode? node))
        {
            result.Add(node.val);
        }

        return result;

        void BuildParents(TreeNode node)
        {
            if (node == target)
            {
                return;
            }

            if (node.left != null)
            {
                parents[node.left] = node;
                BuildParents(node.left);
            }

            if (node.right != null)
            {
                parents[node.right] = node;
                BuildParents(node.right);
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
