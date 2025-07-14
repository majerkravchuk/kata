using Kata.Common;

namespace Kata.Solutions;

public class MaxPQ<T>(int capacity) : IPriorityQueue<T> where T : IComparable<T> {
    public readonly T[] Items = new T[capacity + 1]; // does not use _items[0]

    public int Size { get; private set; } = 0;

    public bool IsEmpty => Size <= 1;

    public void Insert(T item) {
        Items[++Size] = item;
        Swim(Size);
    }

    public T DeleteMax() {
        var max = Items[1];
        Exch(1, Size--);
        Sink(1);
        return max;
    }

    private void Swim(int k) {
        while (k > 1 && Less(k >> 1, k)) {
            Exch(k >> 1, k);
            k >>= 1;
        }
    }

    private void Sink(int k) {
        while (k * 2 <= Size) {
            int j = k * 2;                  // right children
            if (j < Size && Less(j, j + 1))
                j++;                        // left children

            if (Less(j, k))
                break;

            Exch(j, k);
            k = j;
        }
    }

    private bool Less(int i, int j) {
        return Items[i].CompareTo(Items[j]) < 0;
    }

    private void Exch(int i, int j) {
        (Items[i], Items[j]) = (Items[j], Items[i]);
    }
}
