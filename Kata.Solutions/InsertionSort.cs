namespace Kata.Solutions;

public class InsertionSort
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        for (int i = 1; i < array.Length; i++)
            for (int j = i; j > 0 && Less(array[j], array[j - 1]); j--)
                Exch(array, j, j - 1);
    }

    private static bool Less<T>(T v, T w) where T : IComparable<T> {
        return v.CompareTo(w) < 0;
    }

    private static void Exch<T>(T[] a, int i, int j) where T : IComparable<T> {
        (a[j], a[i]) = (a[i], a[j]);
    }
}
