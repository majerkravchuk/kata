namespace Kata.Solutions;

public class SelectionSort
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        for (int i = 0; i < array.Length; i++)
        {
            var m = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (Less(array[j], array[m]))
                {
                    m = j;
                }
            }

            if (m != i)
            {
                Exch(array, m, i);
            }
        }
    }

    private static bool Less<T>(T v, T w) where T : IComparable<T> {
        return v.CompareTo(w) < 0;
    }

    private static void Exch<T>(T[] a, int i, int j) where T : IComparable<T> {
        (a[j], a[i]) = (a[i], a[j]);
    }
}
