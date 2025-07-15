using Kata.Common;

namespace Kata.Solutions;

public class BinarySearchST<TKey, TValue>(int capacity) : ISymbolTable<TKey, TValue> where TKey : IComparable<TKey> {
    private readonly TKey[] _keys = new TKey[capacity];
    private readonly TValue?[] _values = new TValue[capacity];

    public int Size { get; private set; } = 0;

    public bool IsEmpty => Size == 0;

    public TValue? Get(TKey key) {
        if (IsEmpty) return default;
        var rank = Rank(key);
        if (rank < Size && _keys[rank].Equals(key))
            return _values[rank];
        return default;
    }

    public void Set(TKey key, TValue? value) {
        var rank = Rank(key);
        if (rank < Size && _keys[rank].Equals(key)) {
            _values[rank] = value;
            return;
        }
        for (int i = Size; i > rank; i--) {
            _keys[i] = _keys[i - 1];
            _values[i] = _values[i - 1];
        }
        _keys[rank] = key;
        _values[rank] = value;
        Size++;
    }

    private int Rank(TKey key) {
        var lo = 0;
        var hi = Size - 1;
        while (lo <= hi) {
            var mid = lo + ((hi - lo) >> 1);
            var cmp = key.CompareTo(_keys[mid]);
            if (cmp < 0) hi = mid - 1;
            else if (cmp > 0) lo = mid + 1;
            else return mid;
        }
        return lo;
    }
}
