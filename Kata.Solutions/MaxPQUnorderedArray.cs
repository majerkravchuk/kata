using Kata.Common;

namespace Kata.Solutions;

public class MaxPQUnorderedArray<T>(int capacity) : IPriorityQueue<T> where T : IComparable<T> {
    private readonly T[] _items = new T[capacity];

    public bool IsEmpty => Size == 0;

    public int Size { get; private set; } = 0;

    public T DeleteMax() {
        var m = 0;

        for (int i = 0; i < Size; i++)
            if (Less(_items[m], _items[i])) m = i;

        Exch(m, Size - 1);
        return _items[--Size];
    }

    public void Insert(T item) {
        _items[Size++] = item;
    }

    private static bool Less(T v, T w) {
        return v.CompareTo(w) < 0;
    }

    private void Exch(int i, int j) {
        (_items[j], _items[i]) = (_items[i], _items[j]);
    }
}
