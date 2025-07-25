```c#
private static int IndexOf<T>(T[] array, T value) where T : IComparable<T> {
    var lo = 0;
    var hi = array.Length - 1;

    while (lo <= hi) {
        var mid = lo + ((hi - lo) >> 1);
        var cmp = value.CompareTo(array[mid]);

        if (cmp == 0) return mid;
        if (cmp < 0) hi = mid - 1;
        else lo = mid + 1;
    }

    return -1;
}
```
