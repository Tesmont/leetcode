namespace LeetCode.P00399EvaluateDivision.Initial;

/// <summary>
/// LeetCode 399. Evaluate Division.
/// https://leetcode.com/problems/evaluate-division/
/// </summary>
public sealed class Solution
{
    public double[] CalcEquation(
        IList<IList<string>> equations,
        double[] values,
        IList<IList<string>> queries)
    {
        Dictionary<string, Dictionary<string, double>> adjacencyList = [];
        for (int i = 0; i < equations.Count; i++)
        {
            string leftVariable = equations[i][0];
            string rightVariable = equations[i][1];
            double equationResult = values[i];

            if (!adjacencyList.TryGetValue(leftVariable, out Dictionary<string, double>? leftNeighbors))
            {
                leftNeighbors = new();
                adjacencyList.Add(leftVariable, leftNeighbors);
            }

            if (!adjacencyList.TryGetValue(rightVariable, out Dictionary<string, double>? rightNeighbors))
            {
                rightNeighbors = new();
                adjacencyList.Add(rightVariable, rightNeighbors);
            }

            leftNeighbors.Add(rightVariable, equationResult);
            rightNeighbors.Add(leftVariable, 1 / equationResult);
        }

        double[] queriesResults = new double[queries.Count];

        for (int i = 0; i < queries.Count; i++)
        {
            string source = queries[i][0];
            string target = queries[i][1];

            queriesResults[i] = Evaluate(source, target, adjacencyList);
        }

        return queriesResults;

        static double Evaluate(
            string source,
            string target,
            Dictionary<string, Dictionary<string, double>> adjacencyList)
        {
            if (!adjacencyList.ContainsKey(source) || !adjacencyList.ContainsKey(target))
            {
                return -1.0;
            }

            if (source == target)
            {
                return 1.0;
            }

            Queue<(string Variable, double Value)> queue = new();
            HashSet<string> seen = [];

            queue.Enqueue((source, 1.0));
            seen.Add(source);

            while (queue.Count > 0)
            {
                (string variable, double currentValue) = queue.Dequeue();

                foreach ((string nextVariable, double edgeValue) in adjacencyList[variable])
                {
                    if (!seen.Add(nextVariable))
                    {
                        continue;
                    }

                    double nextValue = currentValue * edgeValue;

                    if (nextVariable == target)
                    {
                        return nextValue;
                    }

                    queue.Enqueue((nextVariable, nextValue));
                }
            }

            return -1.0;
        }
    }
}
