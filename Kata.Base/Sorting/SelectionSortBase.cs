namespace Kata.Base.Sorting;

public class SelectionSortBase {
    public virtual void Sort<T>(T[] array) where T : IComparable<T> {
        for (var i = 0; i < array.Length; i++) {
            var m = i;
            for (var j = i + 1; j < array.Length; j++)
                if (Less(array[j], array[m]))
                    m = j;

            if (m != i)
                Exchange(array, m, i);
        }
    }

    protected static bool Less<T>(T v, T w) where T : IComparable<T> {
        return v.CompareTo(w) < 0;
    }

    protected static void Exchange<T>(T[] a, int i, int j) where T : IComparable<T> {
        (a[j], a[i]) = (a[i], a[j]);
    }
}
