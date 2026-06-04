namespace LeetCode.P00707DesignLinkedList.SinglyLinkedList;

/// <summary>
/// LeetCode 707. Design Linked List.
/// https://leetcode.com/problems/design-linked-list/
/// </summary>
public sealed class MyLinkedList
{
    public MyLinkedList()
    {
        _sentinelHead = new ListNode();
        _sentinelTail = new ListNode();
        _sentinelHead.Next = _sentinelTail;
        _sentinelTail.Previous = _sentinelHead;
    }

    public int Get(int index)
    {
        if (!IsValidIndex(index))
        {
            return -1;
        }

        return GetNodeAt(index).Value;
    }

    public void AddAtHead(int val)
    {
        InsertBefore(_sentinelHead.Next, val);
    }

    public void AddAtTail(int val)
    {
        InsertBefore(_sentinelTail, val);
    }

    public void AddAtIndex(int index, int val)
    {
        if (index <= 0)
        {
            AddAtHead(val);
            return;
        }

        if (index == _length)
        {
            AddAtTail(val);
            return;
        }

        if (index > _length)
        {
            return;
        }

        ListNode next = GetNodeAt(index);
        InsertBefore(next, val);
    }

    public void DeleteAtIndex(int index)
    {
        if (!IsValidIndex(index))
        {
            return;
        }

        ListNode node = GetNodeAt(index);
        node.Previous.Next = node.Next;
        node.Next.Previous = node.Previous;
        _length--;
    }

    private sealed class ListNode
    {
        public int Value { get; init; }

        public ListNode Next { get; set; } = null!;

        public ListNode Previous { get; set; } = null!;
    }

    private int _length;
    private readonly ListNode _sentinelHead;
    private readonly ListNode _sentinelTail;

    private bool IsValidIndex(int index)
    {
        return index >= 0 && index < _length;
    }

    private void InsertBefore(ListNode next, int value)
    {
        ListNode previous = next.Previous;
        ListNode node = new()
        {
            Value = value,
            Next = next,
            Previous = previous
        };

        previous.Next = node;
        next.Previous = node;
        _length++;
    }

    private ListNode GetNodeAt(int index)
    {
        if (index < _length / 2)
        {
            ListNode current = _sentinelHead.Next;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current;
        }

        ListNode node = _sentinelTail.Previous;
        for (int i = _length - 1; i > index; i--)
        {
            node = node.Previous;
        }

        return node;
    }
}
