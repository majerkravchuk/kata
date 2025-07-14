namespace Kata.Common;

public interface IPriorityQueue<T> {
    void Insert(T item);
    T DeleteMax();
    int Size { get; }
    bool IsEmpty { get; }
}
