namespace Kata.Solutions;

public class MergeSort {
    public static void Sort<T>(T[] a) where T : IComparable<T> {
        T[] aux = new T[a.Length];
        Sort(a, aux, 0, a.Length - 1);
    }

    private static void Merge<T>(T[] a, T[] aux, int lo, int mid, int hi) where T : IComparable<T> {
        int i = lo;
        int j = mid + 1;

        for (var k = lo; k <= hi; k++)
            aux[k] = a[k];

        for (var k = lo; k <= hi; k++) {
            if (i > mid) a[k] = aux[j++];
            else if (j > hi) a[k] = aux[i++];
            else if (Less(aux[j], aux[i])) a[k] = aux[j++];
            else a[k] = aux[i++];
        }
    }

    private static void Sort<T>(T[] a, T[] aux, int lo, int hi) where T : IComparable<T> {
        if (hi <= lo) return;

        int mid = lo + (hi - lo) / 2;

        Sort(a, aux, lo, mid);
        Sort(a, aux, mid + 1, hi);

        Merge(a, aux, lo, mid, hi);
    }

    private static bool Less<T>(T v, T w) where T : IComparable<T> {
        return v.CompareTo(w) < 0;
    }
}
