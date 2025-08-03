```c#
public void Insert(T item) {
    _items[++Size] = item;
    Swim(Size);
}

public T DeleteMax() {
    var max = _items[1];
    Exchange(1, Size--);
    Sink(1);
    return max;
}

private void Swim(int k) {
    for (var i = k; i > 1 && Less(i / 2, i); i /= 2)
        Exchange(i / 2, i);
}

private void Sink(int k) {
    while (k * 2 <= Size) {
        var i = k * 2;
        if (i < Size && Less(i, i + 1)) i++;
        if (Less(i, k)) break;
        Exchange(i, k);
        k = i;
    }
}
```
