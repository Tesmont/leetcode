using Xunit;

namespace LeetCode.Tests.P02434UsingARobotToPrintTheLexicographicallySmallestString;

public static class SolutionTestCases
{
    public static TheoryData<string, string> RobotWithStringCases =>
        new()
        {
            { "zza", "azz" },
            { "bac", "abc" },
            { "bdda", "addb" },
            { "cba", "abc" },
        };
}
