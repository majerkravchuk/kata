```c#
public void Insert(T item)
{
    _items[++Size] = item;
    for (var i = Size; i > 1 && Less(i / 2, i); i /= 2)
        Exchange(i / 2, i);
}

public T DeleteMax()
{
    var max = _items[1];

    var k = 1;
    Exchange(k, Size--);

    while (k * 2 <= Size)
    {
        var i = k * 2;
        if (i < Size && Less(i, i + 1)) i++;
        if (Less(i, k)) break;
        Exchange(i, k);
        k = i;
    }

    return max;
}
```
