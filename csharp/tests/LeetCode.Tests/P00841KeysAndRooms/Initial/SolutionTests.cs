using LeetCode.P00841KeysAndRooms.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00841KeysAndRooms.SolutionTestCases;

namespace LeetCode.Tests.P00841KeysAndRooms.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.CanVisitAllRoomsCases), MemberType = typeof(RootSolutionTestCases))]
    public void CanVisitAllRooms_ReturnsWhetherEveryRoomIsReachable(int[][] roomValues, bool expected)
    {
        Solution solution = new();
        IList<IList<int>> rooms = ToRooms(roomValues);

        bool actual = solution.CanVisitAllRooms(rooms);

        Assert.Equal(expected, actual);
    }

    private static IList<IList<int>> ToRooms(int[][] roomValues)
    {
        List<IList<int>> rooms = [];

        foreach (int[] room in roomValues)
        {
            rooms.Add(room);
        }

        return rooms;
    }
}
