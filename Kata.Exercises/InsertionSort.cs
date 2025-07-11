namespace Kata.Exercises;

public class InsertionSort
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        throw new NotImplementedException();
    }

    private static bool Less<T>(T v, T w) where T : IComparable<T> {
        return v.CompareTo(w) < 0;
    }

    private static void Exch<T>(T[] a, int i, int j) where T : IComparable<T> {
        (a[j], a[i]) = (a[i], a[j]);
    }
}
