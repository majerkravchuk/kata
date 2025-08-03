```c#
public static void Sort<T>(T[] array) where T : IComparable<T> {
    var aux = new T[array.Length];
    Sort(array, aux, 0, array.Length - 1);
}

private static void Sort<T>(T[] array, T[] aux, int lo, int hi) where T : IComparable<T> {
    if (lo >= hi) return;
    var mid = lo + ((hi - lo) >> 1);
    Sort(array, aux, lo, mid);
    Sort(array, aux, mid + 1, hi);
    Merge(array, aux, lo, mid, hi);
}

private static void Merge<T>(T[] array, T[] aux, int lo, int mid, int hi) where T : IComparable<T> {
    var i = lo;
    var j = mid + 1;

    for (var k = lo; k <= hi; k++)
        aux[k] = array[k];

    for (var k = lo; k <= hi; k++) {
        if (i > mid) array[k] = aux[j++];
        else if (j > hi) array[k] = aux[i++];
        else if (Less(aux[j], aux[i])) array[k] = aux[j++];
        else array[k] = aux[i++];
    }
}
```
