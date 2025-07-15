using Kata.Common;

namespace Kata.Solutions;

public class SequentialSearchST<TKey, TValue> : ISymbolTable<TKey, TValue> where TKey : IComparable<TKey> {
    public int Size => throw new NotImplementedException();

    public bool IsEmpty => throw new NotImplementedException();

    public TValue? Get(TKey key) {
        throw new NotImplementedException();
    }

    public void Set(TKey key, TValue? value) {
        throw new NotImplementedException();
    }
}
