```c#
public static void Sort<T>(T[] array) where T : IComparable<T>
{
    Sort(array, 0, array.Length - 1);
}

private static void Sort<T>(T[] array, int lo, int hi) where T : IComparable<T>
{
    if (lo >= hi) return;
    var pt = Partition(array, lo, hi);
    Sort(array, lo, pt - 1);
    Sort(array, pt + 1, hi);
}

private static int Partition<T>(T[] array, int lo, int hi) where T : IComparable<T>
{
    var i = lo;
    var j = hi + 1;
    var pt = array[lo];

    while (true)
    {
        while (array[++i].CompareTo(pt) < 0 && i != hi) { }
        while (pt.CompareTo(array[--j]) < 0 && j != lo) { }
        if (i >= j) break;
        Exchange(array, i, j);
    }
    Exchange(array, lo, j);
    return j;
}
```
