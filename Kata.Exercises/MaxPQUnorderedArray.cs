using Kata.Common;

namespace Kata.Exercises;

public class MaxPQUnorderedArray<T>(int capacity) : IPriorityQueue<T> where T : IComparable<T> {
    private readonly T[] _items = new T[capacity];

    public bool IsEmpty => throw new NotImplementedException();

    public int Size => throw new NotImplementedException();

    public T DeleteMax() {
        throw new NotImplementedException();
    }

    public void Insert(T item) {
        throw new NotImplementedException();
    }

    private static bool Less(T v, T w) {
        return v.CompareTo(w) < 0;
    }

    private void Exch(int i, int j) {
        (_items[j], _items[i]) = (_items[i], _items[j]);
    }
}
