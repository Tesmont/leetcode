using LeetCode.P00707DesignLinkedList.SinglyLinkedList;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00707DesignLinkedList.SolutionTestCases;

namespace LeetCode.Tests.P00707DesignLinkedList.SinglyLinkedList;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MyLinkedListCases), MemberType = typeof(RootSolutionTestCases))]
    public void MyLinkedList_ExecutesOperations(string[] operations, int[][] arguments, int?[] expected)
    {
        MyLinkedList? linkedList = null;
        List<int?> actual = [];

        for (int i = 0; i < operations.Length; i++)
        {
            actual.Add(ExecuteOperation(ref linkedList, operations[i], arguments[i]));
        }

        Assert.Equal(expected, actual);
    }

    private static int? ExecuteOperation(ref MyLinkedList? linkedList, string operation, int[] arguments)
    {
        switch (operation)
        {
            case "MyLinkedList":
                linkedList = new MyLinkedList();
                return null;

            case "get":
                return linkedList!.Get(arguments[0]);

            case "addAtHead":
                linkedList!.AddAtHead(arguments[0]);
                return null;

            case "addAtTail":
                linkedList!.AddAtTail(arguments[0]);
                return null;

            case "addAtIndex":
                linkedList!.AddAtIndex(arguments[0], arguments[1]);
                return null;

            case "deleteAtIndex":
                linkedList!.DeleteAtIndex(arguments[0]);
                return null;

            default:
                throw new System.ArgumentOutOfRangeException(nameof(operation), operation, null);
        }
    }
}
