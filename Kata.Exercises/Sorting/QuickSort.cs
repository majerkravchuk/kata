namespace Kata.Exercises.Sorting;

public class QuickSort
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        throw new NotImplementedException();
    }

    private static bool Less<T>(T i, T j) where T : IComparable<T>
    {
        return i.CompareTo(j) < 0;
    }

    private static void Exchange<T>(T[] array, int i, int j)
    {
        (array[i], array[j]) = (array[j], array[i]);
    }
}
