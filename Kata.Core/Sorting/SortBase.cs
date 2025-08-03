namespace Kata.Core.Sorting;

public class SortBase
{
    protected static bool Less<T>(T i, T j) where T : IComparable<T>
    {
        return i.CompareTo(j) < 0;
    }

    protected static void Exchange<T>(T[] array, int i, int j)
    {
        (array[i], array[j]) = (array[j], array[i]);
    }
}
