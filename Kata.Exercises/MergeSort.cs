namespace Kata.Exercises;

/**
 * merge(l, m, h);
 *
 * [3, 5, 9, 1, 4, 7] // array
 * [0  1  2][3  4  5] // indexes
 *  l     m        h  // passed to merge call
 *  i        j        // internal pointers
 */

public class MergeSort {
    public static void Sort<T>(T[] a) where T : IComparable<T> {
        throw new NotImplementedException();
    }

    private static bool Less<T>(T v, T w) where T : IComparable<T> {
        return v.CompareTo(w) < 0;
    }
}
