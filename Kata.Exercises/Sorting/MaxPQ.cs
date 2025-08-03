namespace Kata.Exercises.Sorting;

/**
 * A binary heap is a collection of keys arranged in a complete heap-ordered
 * binary tree, represented in level order in an array (not using the first entry).
 *
 *        i   0  1  2  3  4  5  6  7  8  9 10 11
 * _items[i]  - 84 83 82 80 78 79 65 69 73 72 71
 *
 *                84
 *        ┌───────┴───────┐
 *       83              82
 *    ┌───┴───┐       ┌───┴───┐
 *   80      78      79      65
 *  ┌─┴─┐   ┌─┴─┐
 * 69  73  72  71
 *
 * The parent of the node in position k is in position ⌊k/2⌋.
 * The two children of the node in position k are in positions 2k and 2k + 1.
 *
 * Reminder: swim (up) and sink (down)/
 */

public class MaxPQ<T>(int capacity) where T : IComparable<T> {
    private readonly T[] _items = new T[capacity + 1];

    public int Size { get; private set; } = 0;
    public bool IsEmpty => Size <= 1;

    public void Insert(T item) {
        throw new NotImplementedException();
    }

    public T DeleteMax() {
        throw new NotImplementedException();
    }

    private bool Less(int i, int j) {
        return _items[i].CompareTo(_items[j]) < 0;
    }

    private void Exchange(int i, int j) {
        (_items[i], _items[j]) = (_items[j], _items[i]);
    }
}
