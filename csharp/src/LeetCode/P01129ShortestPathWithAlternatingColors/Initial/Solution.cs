namespace LeetCode.P01129ShortestPathWithAlternatingColors.Initial;

/// <summary>
/// LeetCode 1129. Shortest Path with Alternating Colors.
/// https://leetcode.com/problems/shortest-path-with-alternating-colors/
/// </summary>
public sealed class Solution
{
    public int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges)
    {
        List<int>[] redAdjacencyList = new List<int>[n];
        List<int>[] blueAdjacencyList = new List<int>[n];
        for (int vertex = 0; vertex < n; vertex++)
        {
            redAdjacencyList[vertex] = new();
            blueAdjacencyList[vertex] = new();
        }

        foreach (int[] edge in redEdges)
        {
            redAdjacencyList[edge[0]].Add(edge[1]);
        }

        foreach (int[] edge in blueEdges)
        {
            blueAdjacencyList[edge[0]].Add(edge[1]);
        }

        Span<bool> redSeen = stackalloc bool[n];
        Span<bool> blueSeen = stackalloc bool[n];

        Queue<(int Vertex, bool LastEdgeWasRed)> queue = new();

        redSeen[0] = true;
        blueSeen[0] = true;
        queue.Enqueue((0, true));
        queue.Enqueue((0, false));

        int[] distances = new int[n];
        Array.Fill(distances, -1);

        int currentDistance = 0;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++)
            {
                (int vertex, bool lastEdgeWasRed) = queue.Dequeue();

                if (distances[vertex] == -1)
                {
                    distances[vertex] = currentDistance;
                }

                if (lastEdgeWasRed)
                {
                    foreach (int nextVertex in blueAdjacencyList[vertex])
                    {
                        if (blueSeen[nextVertex])
                        {
                            continue;
                        }

                        blueSeen[nextVertex] = true;
                        queue.Enqueue((nextVertex, false));
                    }
                }
                else
                {
                    foreach (int nextVertex in redAdjacencyList[vertex])
                    {
                        if (redSeen[nextVertex])
                        {
                            continue;
                        }

                        redSeen[nextVertex] = true;
                        queue.Enqueue((nextVertex, true));
                    }
                }
            }

            currentDistance++;
        }

        return distances;
    }
}
