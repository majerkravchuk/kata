using Kata.Common;

namespace Kata.Solutions;

public class MaxPQOrderedArray<T>(int capacity) : IPriorityQueue<T> where T : IComparable<T> {
    private readonly T[] _items = new T[capacity];

    public bool IsEmpty => Size == 0;

    public int Size { get; private set; } = 0;

    public T DeleteMax() {
        return _items[--Size];
    }

    public void Insert(T item) {
        int i = Size - 1;
        while (i >= 0 && Less(item, _items[i])) {
            _items[i + 1] = _items[i];
            i--;
        }
        _items[i + 1] = item;
        Size++;
    }

    private static bool Less(T v, T w) {
        return v.CompareTo(w) < 0;
    }
}
