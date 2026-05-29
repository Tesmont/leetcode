using Xunit;

namespace LeetCode.Tests.P00451SortCharactersByFrequency;

public static class SolutionTestCases
{
    public static TheoryData<string> FrequencySortCases =>
        new()
        {
            "tree",
            "cccaaa",
            "Aabb",
            "raaeaedere",
            "a",
        };
}
