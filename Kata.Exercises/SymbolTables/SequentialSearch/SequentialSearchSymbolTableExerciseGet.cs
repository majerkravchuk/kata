using Kata.Base.SymbolTables;

namespace Kata.Exercises.SymbolTables.SequentialSearch;

public class SequentialSearchSymbolTableExerciseGet<TKey, TValue>
    : SequentialSearchSymbolTableExerciseBase<TKey, TValue>
    where TKey : IComparable<TKey>
{
    public override TValue? Get(TKey key)
    {
        return default;
    }
}
