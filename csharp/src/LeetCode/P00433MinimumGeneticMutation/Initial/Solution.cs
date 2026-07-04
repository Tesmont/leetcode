namespace LeetCode.P00433MinimumGeneticMutation.Initial;

/// <summary>
/// LeetCode 433. Minimum Genetic Mutation.
/// https://leetcode.com/problems/minimum-genetic-mutation/
/// </summary>
public sealed class Solution
{
    public int MinMutation(string startGene, string endGene, string[] bank)
    {
        int n = bank.Length;

        int endIndex = Array.IndexOf(bank, endGene);
        if (endIndex == -1)
        {
            return -1;
        }

        bool[] seen = new bool[n];
        Queue<string> queue = new();

        queue.Enqueue(startGene);

        int distance = 0;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++)
            {
                string gene = queue.Dequeue();

                if (gene == endGene)
                {
                    return distance;
                }

                for (int j = 0; j < n; j++)
                {
                    if (seen[j])
                    {
                        continue;
                    }

                    if (!CanMutate(gene, bank[j]))
                    {
                        continue;
                    }

                    seen[j] = true;
                    queue.Enqueue(bank[j]);
                }
            }

            distance++;
        }

        return -1;
    }

    private static bool CanMutate(string left, string right)
    {
        int differences = 0;

        for (int i = 0; i < left.Length; i++)
        {
            if (left[i] != right[i])
            {
                differences++;

                if (differences > 1)
                {
                    return false;
                }
            }
        }

        return differences == 1;
    }
}
