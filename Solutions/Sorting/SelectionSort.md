```c#
public static void Sort<T>(T[] array) where T : IComparable<T> {
    for (var i = 0; i < array.Length; i++) {
        var m = i;
        for (var j = i + 1; j < array.Length; j++)
            if (Less(array[j], array[m]))
                m = j;

        if (m != i)
            Exchange(array, m, i);
    }
}
```
