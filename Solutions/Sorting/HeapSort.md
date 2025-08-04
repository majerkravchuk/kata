```c#
namespace Kata.Exercises.Sorting;

public static class HeapSort
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        var n = array.Length;
        for (var i = n / 2; i >= 1; i--)
            Sink(array, i, n);

        while (n > 1)
        {
            Exchange(array, 1, n--);
            Sink(array, 1, n);
        }
    }

    private static void Sink<T>(T[] array, int i, int n) where T : IComparable<T>
    {
        while (i * 2 <= n)
        {
            var j = i * 2;
            if (j < n && Less(array, j, j + 1)) j++;
            if (Less(array, j, i))
                break;
            Exchange(array, i, j);
            i = j;
        }
    }

    private static bool Less<T>(T[] array, int i, int j) where T : IComparable<T>
    {
        return array[i - 1].CompareTo(array[j - 1]) < 0;
    }

    private static void Exchange<T>(T[] array, int i, int j)
    {
        (array[i - 1], array[j - 1]) = (array[j - 1], array[i - 1]);
    }
}

```
