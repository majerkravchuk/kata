using Kata.Common;

namespace Kata.Exercises;

public class MaxPQ<T>(int capacity) : IPriorityQueue<T> where T : IComparable<T> {
    public readonly T[] Items = new T[capacity + 1]; // does not use _items[0]

    public int Size { get; private set; } = 0;

    public bool IsEmpty => Size == 1;

    public void Insert(T item) {
        throw new NotImplementedException();
    }

    public T DeleteMax() {
        throw new NotImplementedException();
    }

    private bool Less(int i, int j) {
        return Items[i].CompareTo(Items[j]) < 0;
    }

    private void Exch(int i, int j) {
        (Items[i], Items[j]) = (Items[j], Items[i]);
    }
}
