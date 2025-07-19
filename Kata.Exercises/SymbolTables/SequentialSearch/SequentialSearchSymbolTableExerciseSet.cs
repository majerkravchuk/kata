using Kata.Base.SymbolTables;

namespace Kata.Exercises.SymbolTables.SequentialSearch;

public class SequentialSearchSymbolTableExerciseSet<TKey, TValue>
    : SequentialSearchSymbolTableExerciseBase<TKey, TValue>
    where TKey : IComparable<TKey>
{
    public override void Set(TKey key, TValue? value)
    {
    }
}
