namespace Kata.Core;

public static class SortingHelper {
    public static bool Less<T>(T v, T w) where T : IComparable<T>
    {
        return v.CompareTo(w) < 0;
    }

    public static void Exchange<T>(T[] a, int i, int j) where T : IComparable<T>
    {
        (a[j], a[i]) = (a[i], a[j]);
    }
}
