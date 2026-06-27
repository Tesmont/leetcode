namespace LeetCode.P00841KeysAndRooms.Initial;

/// <summary>
/// LeetCode 841. Keys and Rooms.
/// https://leetcode.com/problems/keys-and-rooms/
/// </summary>
public sealed class Solution
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        bool[] visited = new bool[rooms.Count];
        int visitedRoomCount = 0;

        CheckTheRoom(0);

        return visitedRoomCount == rooms.Count;

        void CheckTheRoom(int room)
        {
            visited[room] = true;
            visitedRoomCount++;

            IList<int> keys = rooms[room];
            foreach (int key in keys)
            {
                if (!visited[key])
                {
                    CheckTheRoom(key);
                }
            }
        }
    }
}
