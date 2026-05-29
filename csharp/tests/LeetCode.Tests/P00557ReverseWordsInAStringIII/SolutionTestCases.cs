using Xunit;

namespace LeetCode.Tests.P00557ReverseWordsInAStringIII;

public static class SolutionTestCases
{
    public static TheoryData<string, string> ReverseWordsCases =>
        new()
        {
            { "Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc" },
            { "God Ding", "doG gniD" },
        };
}
