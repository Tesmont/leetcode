namespace LeetCode.P00912SortAnArray.MinHeap;

/// <summary>
/// LeetCode 912. Sort an Array.
/// https://leetcode.com/problems/sort-an-array/
/// </summary>

public sealed class MinHeap<T>
{
    public MinHeap(IComparer<T>? comparer)
    {
        _items = new();
        _comparer = comparer ?? Comparer<T>.Default;
    }

    public MinHeap(IEnumerable<T> set, IComparer<T>? comparer)
    {
        _items = set.ToList();
        _comparer = comparer ?? Comparer<T>.Default;

        Heapify();
    }

    public int Count => _items.Count;

    public T Peak()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("Heap is empty.");
        }

        return _items[0];
    }

    public T Pop()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("Heap is empty.");
        }

        T root = _items[0];

        int lastIndex = _items.Count - 1;
        _items[0] = _items[lastIndex];
        _items.RemoveAt(lastIndex);

        if (_items.Count > 0)
        {
            SiftDown(0);
        }

        return root;
    }

    public void Push(T value)
    {
        _items.Add(value);
        SiftUp();
    }

    private readonly List<T> _items;
    private readonly IComparer<T> _comparer;

    private void Heapify()
    {
        for (int i = _items.Count / 2 - 1; i >= 0; i--)
        {
            SiftDown(i);
        }
    }

    private void SiftUp()
    {
        int childIndex = _items.Count - 1;
        while (childIndex > 0)
        {
            int parentIndex = (childIndex - 1) / 2;

            if (_comparer.Compare(_items[childIndex], _items[parentIndex]) >= 0)
            {
                break;
            }

            (_items[childIndex], _items[parentIndex]) = (_items[parentIndex], _items[childIndex]);
            childIndex = parentIndex;
        }
    }

    private void SiftDown(int parentIndex)
    {
        while (true)
        {
            int leftChildIndex = parentIndex * 2 + 1;
            int rightChildIndex = parentIndex * 2 + 2;
            int smallestChildIndex = parentIndex;

            if (leftChildIndex < _items.Count &&
                _comparer.Compare(_items[leftChildIndex], _items[smallestChildIndex]) < 0)
            {
                smallestChildIndex = leftChildIndex;
            }

            if (rightChildIndex < _items.Count &&
                _comparer.Compare(_items[rightChildIndex], _items[smallestChildIndex]) < 0)
            {
                smallestChildIndex = rightChildIndex;
            }

            if (smallestChildIndex == parentIndex)
            {
                break;
            }

            (_items[smallestChildIndex], _items[parentIndex]) = (_items[parentIndex], _items[smallestChildIndex]);
            parentIndex = smallestChildIndex;
        }
    }
}

public sealed class Solution
{
    public int[] SortArray(int[] nums)
    {
        MinHeap<int> minHeap = new(nums, Comparer<int>.Default);
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = minHeap.Pop();
        }

        return nums;
    }
}
