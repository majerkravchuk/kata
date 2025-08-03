namespace Kata.Core.Sorting;

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

public class MaxPQBase<T>(int capacity) where T : IComparable<T>
{
    protected readonly T[] Items = new T[capacity + 1];

    public int Size { get; protected set; } = 0;
    public bool IsEmpty => Size <= 1;

    public virtual void Insert(T item)
    {
        Items[++Size] = item;
        for (var i = Size; i > 1 && Less(i / 2, i); i /= 2)
            Exchange(i / 2, i);
    }

    public virtual T DeleteMax()
    {
        var max = Items[1];

        var k = 1;
        Exchange(k, Size--);

        while (k * 2 <= Size)
        {
            var i = k * 2;
            if (i < Size && Less(i, i + 1)) i++;
            if (Less(i, k)) break;
            Exchange(i, k);
            k = i;
        }

        return max;
    }

    protected bool Less(int i, int j)
    {
        return Items[i].CompareTo(Items[j]) < 0;
    }

    protected void Exchange(int i, int j)
    {
        (Items[i], Items[j]) = (Items[j], Items[i]);
    }
}
