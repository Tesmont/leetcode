using LeetCode.P00234PalindromeLinkedList.ThreePasses;
using Xunit;

namespace LeetCode.Tests.P00234PalindromeLinkedList.ThreePasses;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.IsPalindromeCases), MemberType = typeof(SolutionTestCases))]
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
