using Xunit;

namespace LeetCode.Tests.P00071SimplifyPath;

public static class SolutionTestCases
{
    public static TheoryData<string, string> SimplifyPathCases =>
        new()
        {
            { "/home/", "/home" },
            { "/home//foo/", "/home/foo" },
            { "/home/user/Documents/../Pictures", "/home/user/Pictures" },
            { "/../", "/" },
            { "/.../a/../b/c/../d/./", "/.../b/d" },
        };
}
