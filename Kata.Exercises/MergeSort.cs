namespace Kata.Exercises;

public class MergeSort {
    public static void Sort<T>(T[] a) where T : IComparable<T> {
        throw new NotImplementedException();
    }

    private static bool Less<T>(T v, T w) where T : IComparable<T> {
        return v.CompareTo(w) < 0;
    }
}
