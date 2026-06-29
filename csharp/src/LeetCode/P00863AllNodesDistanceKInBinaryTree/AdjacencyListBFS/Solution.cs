namespace LeetCode.P00863AllNodesDistanceKInBinaryTree.AdjacencyListBFS;

/// <summary>
/// LeetCode 863. All Nodes Distance K in Binary Tree.
/// https://leetcode.com/problems/all-nodes-distance-k-in-binary-tree/
/// </summary>
public sealed class Solution
{
    public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
    {
        const int maxValues = 500 + 1;
        const int maxNeighbors = 3;
        const int stride = maxNeighbors + 1;

        Span<int> graph = stackalloc int[maxValues * stride];
        BuildAdjacencyList(root, graph);

        Span<bool> seen = stackalloc bool[maxValues];

        Span<int> queue = stackalloc int[maxValues];
        int head = 0;
        int tail = 0;

        queue[tail++] = target.val;
        seen[target.val] = true;

        while (head < tail && k > 0)
        {
            int levelEnd = tail;

            while (head < levelEnd)
            {
                int node = queue[head++];

                int offset = node * stride;
                int neighborCount = graph[offset];

                for (int i = 0; i < neighborCount; i++)
                {
                    int neighbor = graph[offset + 1 + i];

                    if (seen[neighbor])
                    {
                        continue;
                    }

                    seen[neighbor] = true;
                    queue[tail++] = neighbor;
                }
            }

            k--;
        }

        int resultCount = tail - head;
        int[] result = new int[resultCount];

        for (int i = 0; i < resultCount; i++)
        {
            result[i] = queue[head + i];
        }

        return result;

        void BuildAdjacencyList(TreeNode node, Span<int> graph)
        {
            if (node.left != null)
            {
                AddEdge(graph, node.val, node.left.val);
                BuildAdjacencyList(node.left, graph);
            }

            if (node.right != null)
            {
                AddEdge(graph, node.val, node.right.val);
                BuildAdjacencyList(node.right, graph);
            }
        }

        void AddEdge(Span<int> graph, int first, int second)
        {
            AddNeighbor(graph, first, second);
            AddNeighbor(graph, second, first);
        }

        void AddNeighbor(Span<int> graph, int node, int neighbor)
        {
            int offset = node * stride;
            int count = graph[offset];

            graph[offset + 1 + count] = neighbor;
            graph[offset] = count + 1;
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
