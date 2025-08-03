```c#
public void Insert(T item) {
    _items[++Size] = item;
    for (var i = Size; i > 1 && Less(i / 2, i); i /= 2)
        Exchange(i / 2, i);
}
```
