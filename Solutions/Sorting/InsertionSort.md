```c#
private static void Sort<T>(T[] array) where T : IComparable<T> {
    for (var i = 0; i < array.Length; i++)
        for (var j = i; j > 0 && Less(array[j], array[j - 1]); j--)
            Exchange(array, j, j - 1);
}
```
