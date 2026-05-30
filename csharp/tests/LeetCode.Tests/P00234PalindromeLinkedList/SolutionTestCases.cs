using Xunit;

namespace LeetCode.Tests.P00234PalindromeLinkedList;

public static class SolutionTestCases
{
    public static TheoryData<int[], bool> IsPalindromeCases =>
        new()
        {
            { [1, 2, 2, 1], true },
            { [1, 2], false },
            { [1], true },
            { [1, 0, 1], true },
            { [1, 2, 3], false },
        };
}
