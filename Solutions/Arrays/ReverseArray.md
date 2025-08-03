```c#
public static void Reverse<T>(T[] array) where T : IComparable<T> {
    for (int i = 0, j = array.Length - 1; i < j ; i++, j--)
        (array[i], array[j]) = (array[j], array[i]);
}
```
