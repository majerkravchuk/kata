namespace Kata.Base.Sorting;

public class InsertionSortExerciseBase {
    public virtual void Sort<T>(T[] array) where T : IComparable<T> {
        for (int i = 1; i < array.Length; i++)
            for (int j = i; j > 0 && Less(array[j], array[j - 1]); j--)
                Exchange(array, j, j - 1);
    }

    protected static bool Less<T>(T v, T w) where T : IComparable<T> {
        return v.CompareTo(w) < 0;
    }

    protected static void Exchange<T>(T[] a, int i, int j) where T : IComparable<T> {
        (a[j], a[i]) = (a[i], a[j]);
    }
}
