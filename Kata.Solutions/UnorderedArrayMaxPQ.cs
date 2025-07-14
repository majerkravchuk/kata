using Kata.Common;

namespace Kata.Solutions;

public class UnorderedArrayMaxPQ<T>(int capacity) : IPriorityQueue<T> where T : IComparable<T> {
    private readonly T[] _items = new T[capacity];

    public bool IsEmpty => Size == 0;

    public int Size { get; private set; } = 0;

    public T DeleteMax() {
        var m = 0;

        for (int i = 0; i < Size; i++)
            if (Less(m, i)) m = i;

        Exch(m, Size - 1);
        return _items[--Size];
    }

    public void Insert(T item) {
        _items[Size++] = item;
    }

    private bool Less(int v, int w) {
        return _items[v].CompareTo(_items[w]) < 0;
    }

    private void Exch(int i, int j) {
        (_items[j], _items[i]) = (_items[i], _items[j]);
    }
}
