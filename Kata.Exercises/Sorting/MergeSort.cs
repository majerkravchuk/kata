namespace Kata.Exercises.Sorting;

public class MergeSort
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        throw new NotImplementedException();
    }

    private static bool Less<T>(T i, T j) where T : IComparable<T>
    {
        return i.CompareTo(j) < 0;
    }
}
