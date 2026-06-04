namespace LeetCode.P01436DestinationCity.HashSet;

/// <summary>
/// LeetCode 1436. Destination City.
/// https://leetcode.com/problems/destination-city/
/// </summary>
public sealed class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        HashSet<string> sourceCities = new(paths.Count);
        for (int i = 0; i < paths.Count; i++)
        {
            sourceCities.Add(paths[i][0]);
        }

        for (int i = 0; i < paths.Count; i++)
        {
            if (!sourceCities.Contains(paths[i][1]))
            {
                return paths[i][1];
            }
        }

        throw new InvalidOperationException();
    }
}
