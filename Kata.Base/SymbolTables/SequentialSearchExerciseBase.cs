namespace Kata.Base.SymbolTables;

public class SequentialSearchExerciseBase<TKey, TValue> where TKey : IComparable<TKey>
{
    protected class Node
    {
        public required TKey Key;
        public required TValue? Value;
        public Node? Next;
    }

    public int Size { get; private set; } = 0;

    public bool IsEmpty => Size == 0;

    protected Node? _first;

    public virtual TValue? Get(TKey key)
    {
        for (var x = _first; x != null; x = x.Next)
            if (x.Key.Equals(key))
                return x.Value;
        return default;
    }

    public virtual void Set(TKey key, TValue? value)
    {
        for (var x = _first; x != null; x = x.Next)
            if (x.Key.Equals(key))
            {
                x.Value = value;
                return;
            }

        _first = new Node
        {
            Key = key,
            Value = value,
            Next = _first
        };

        Size++;
    }
}
