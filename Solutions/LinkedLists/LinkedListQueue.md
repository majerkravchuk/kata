```c#
public void Enqueue(T value) {
    var node = new Node { Value = value };

    if (_last == null)
        _first = node;
    else
        _last.Next = node;

    _last = node;

    Size++;
}

public T Dequeue() {
    if (_first == null)
        throw new InvalidOperationException("Queue is empty");

    var value = _first.Value;
    _first = _first.Next;

    if (_first == null)
        _last = null;
    
    Size--;
    return value;
}
```
