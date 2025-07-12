using Kata.Common;

namespace Kata.Solutions;

public class ResizingArrayStack<T> : IStack<T> {
    private T[] _array = new T[1];
    private int _n = 0;

    public void Push(T item) {
        if (_n == _array.Length)
            Resize(_array.Length * 2);
        _array[_n++] = item;
    }

    public T Pop() {
        var item = _array[--_n];
        if (_n > 0 && _n == _array.Length / 4)
            Resize(_array.Length / 2);
        return item;
    }

    public bool IsEmpty => _n == 0;

    public int Size => _n;
    public int Capacity => _array.Length;

    private void Resize(int size) {
        T[] t = new T[size];
        for (int i = 0; i < _n; i++)
            t[i] = _array[i];
        _array = t;
    }
}
