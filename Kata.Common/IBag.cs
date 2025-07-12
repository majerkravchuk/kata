namespace Kata.Common;

public interface IBag<T> : IEnumerable<T> {
    void Add(T item);
    bool IsEmpty { get; }
    int Size { get; }
}
