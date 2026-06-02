using Xunit;

namespace LeetCode.Tests.P00844BackspaceStringCompare;

public static class SolutionTestCases
{
    public static TheoryData<string, string, bool> BackspaceCompareCases =>
        new()
        {
            { "ab#c", "ad#c", true },
            { "ab##", "c#d#", true },
            { "a#c", "b", false },
            { "xywrrmp", "xywrrmu#p", true },
            { "###a", "a", true },
            { "bxj##tw", "bxo#j##tw", true },
            { "a##c", "#a#c", true },
        };
}
