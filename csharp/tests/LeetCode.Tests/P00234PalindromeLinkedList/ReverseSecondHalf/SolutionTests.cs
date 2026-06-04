using LeetCode.P00234PalindromeLinkedList.ReverseSecondHalf;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00234PalindromeLinkedList.SolutionTestCases;

namespace LeetCode.Tests.P00234PalindromeLinkedList.ReverseSecondHalf;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.IsPalindromeCases), MemberType = typeof(RootSolutionTestCases))]
    public void IsPalindrome_ReturnsWhetherLinkedListIsPalindrome(int[] values, bool expected)
    {
        Solution solution = new();
        ListNode head = BuildList(values);

        bool actual = solution.IsPalindrome(head);

        Assert.Equal(expected, actual);
    }

    private static ListNode BuildList(int[] values)
    {
        ListNode head = new(values[0]);
        ListNode current = head;

        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }

        return head;
    }
}
