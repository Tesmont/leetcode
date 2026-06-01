using Xunit;

namespace LeetCode.Tests.P00707DesignLinkedList;

public static class SolutionTestCases
{
    public static TheoryData<string[], int[][], int?[]> MyLinkedListCases =>
        new()
        {
            {
                [
                    "MyLinkedList",
                    "addAtHead",
                    "addAtTail",
                    "addAtIndex",
                    "get",
                    "deleteAtIndex",
                    "get",
                ],
                [
                    [],
                    [1],
                    [3],
                    [1, 2],
                    [1],
                    [1],
                    [1],
                ],
                [null, null, null, null, 2, null, 3]
            },
            {
                [
                    "MyLinkedList",
                    "addAtHead",
                    "addAtIndex",
                    "get",
                    "addAtIndex",
                    "addAtTail",
                    "deleteAtIndex",
                    "get",
                ],
                [
                    [],
                    [7],
                    [1, 8],
                    [1],
                    [3, 9],
                    [10],
                    [0],
                    [0],
                ],
                [null, null, null, 8, null, null, null, 8]
            },
            {
                [
                    "MyLinkedList",
                    "addAtHead",
                    "addAtIndex",
                    "get",
                    "deleteAtIndex",
                    "get",
                ],
                [
                    [],
                    [1],
                    [3, 2],
                    [1],
                    [3],
                    [1],
                ],
                [null, null, null, -1, null, -1]
            },
        };
}
