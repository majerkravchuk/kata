using Kata.Common;

namespace Kata.Exercises;

public class BinarySearchST<TKey, TValue>(int capacity) : ISymbolTable<TKey, TValue> where TKey : IComparable<TKey> {
    private readonly TKey[] _keys = new TKey[capacity];
    private readonly TValue?[] _values = new TValue[capacity];

    public int Size => throw new NotImplementedException();

    public bool IsEmpty => throw new NotImplementedException();

    public TValue? Get(TKey key) {
        throw new NotImplementedException();
    }

    public void Set(TKey key, TValue? value) {
        throw new NotImplementedException();
    }
}
