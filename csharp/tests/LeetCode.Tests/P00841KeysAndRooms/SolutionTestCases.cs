using Xunit;

namespace LeetCode.Tests.P00841KeysAndRooms;

public static class SolutionTestCases
{
    public static TheoryData<int[][], bool> CanVisitAllRoomsCases =>
        new()
        {
            { [[1], [2], [3], []], true },
            { [[1, 3], [3, 0, 1], [2], [0]], false },
            { [[]], true },
        };
}
