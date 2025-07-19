using Kata.Base.SymbolTables;

namespace Kata.Exercises.SymbolTables.SequentialSearch;

public class SequentialSearchGetExercise<TKey, TValue>
    : SequentialSearchExerciseBase<TKey, TValue>
    where TKey : IComparable<TKey>
{
    public override TValue? Get(TKey key)
    {
        // ToDo implement!
        return default;
    }
}
