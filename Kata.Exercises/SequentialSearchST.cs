using Kata.Common;

namespace Kata.Exercises;

public class SequentialSearchST<TKey, TValue> : ISymbolTable<TKey, TValue> where TKey : IComparable<TKey> {
    private class Node {
        public required TKey Key;
        public required TValue? Value;
        public Node? Next;
    }

    public int Size { get; private set; } = 0;

    public bool IsEmpty => Size == 0;

    private Node? _first;

    public TValue? Get(TKey key) {
        for (var x = _first; x != null; x = x.Next)
            if (x.Key.Equals(key))
                return x.Value;
        return default;
    }

    public void Set(TKey key, TValue? value) {
        for (var x = _first; x != null; x = x.Next)
            if (x.Key.Equals(key)) {
                x.Value = value;
                return;
            }

        _first = new Node {
            Key = key,
            Value = value,
            Next = _first
        };
        Size++;
    }
}
