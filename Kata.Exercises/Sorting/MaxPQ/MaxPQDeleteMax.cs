using Kata.Core.Sorting;

namespace Kata.Exercises.Sorting.MaxPQ;

public class MaxPQDeleteMax<T>(int capacity) : MaxPQBase<T>(capacity) where T : IComparable<T> {
    public override T DeleteMax() {
        throw new NotImplementedException();
    }
}
