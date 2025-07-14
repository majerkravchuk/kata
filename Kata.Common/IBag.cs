namespace Kata.Common;

public interface IBag<T> : IEnumerable<T> {
    void Add(T item);
    int Size { get; }
    bool IsEmpty { get; }
}
