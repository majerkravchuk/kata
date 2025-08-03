using Kata.Core.Sorting;

namespace Kata.Exercises.Sorting.MaxPQ;

public class MaxPQInsert<T>(int capacity) : MaxPQBase<T>(capacity) where T : IComparable<T> {
    public override void Insert(T item) {
        throw new NotImplementedException();
    }
}
