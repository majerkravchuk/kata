```c#
public static void Sort<T>(T[] array) where T : IComparable<T> {
    Shuffle(array);
    Sort(array, 0, array.Length - 1);
}

private static void Sort<T>(T[] array, int lo, int hi) where T : IComparable<T>
{
    if (lo >= hi) return;
    var p = Partition(array, lo, hi);
    Sort(array, lo, p - 1);
    Sort(array, p + 1, hi);
}

private static int Partition<T>(T[] array, int lo, int hi) where T : IComparable<T> {
    int i = lo, j = hi + 1;

    while (true)
    {
        while (Less(array[++i], array[lo]) && i != hi) {}
        while (Less(array[lo], array[--j])) {}
        if (i >= j) break;
        Exchange(array, i, j);
    }

    Exchange(array, lo, j);
    return j;
}

private static void Shuffle<T>(T[] array) {
    var rand = new Random();
    var n = array.Length;
    for (var i = 0; i < n; i++) {
        var r = i + rand.Next(n - i);
        (array[i], array[r]) = (array[r], array[i]);
    }
}
```
