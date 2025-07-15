namespace Kata.Common;

public interface ISymbolTable<TKey, TValue> {
    TValue? Get(TKey key);
    void Set(TKey key, TValue? value);
    int Size { get; }
    bool IsEmpty { get; }
}
