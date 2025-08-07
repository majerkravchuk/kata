namespace Kata.Exercises.Sorting;

public static class HeapSort {
    public static void Sort<T>(T[] array) where T : IComparable<T> {
        throw new NotImplementedException();
    }

    // Indices are "off-by-one" to support 1-based indexing
    private static bool Less<T>(T[] array, int i, int j) where T : IComparable<T> {
        return array[i - 1].CompareTo(array[j - 1]) < 0;
    }

    // Indices are "off-by-one" to support 1-based indexing
    private static void Exchange<T>(T[] array, int i, int j) {
        (array[i - 1], array[j - 1]) = (array[j - 1], array[i - 1]);
    }
}
