using Kata.Common;

namespace Kata.Exercises;

public class MaxPQOrderedArray<T>(int capacity) : IPriorityQueue<T> where T : IComparable<T> {
    private readonly T[] _items = new T[capacity];

    public int Size => throw new NotImplementedException();

    public bool IsEmpty => throw new NotImplementedException();

    public T DeleteMax() {
        throw new NotImplementedException();
    }

    public void Insert(T item) {
        throw new NotImplementedException();
    }

    private static bool Less(T v, T w) {
        return v.CompareTo(w) < 0;
    }
}
