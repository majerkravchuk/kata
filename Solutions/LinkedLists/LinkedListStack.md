```c#
public void Push(T value) {
    _first = new Node { Value = value,  Next = _first };
    Size++;
}

public T Pop() {
    if (_first == null)
        throw new InvalidOperationException("Stack is empty");

    var value = _first.Value;
    _first = _first.Next;

    Size--;
    return value;
}
```

