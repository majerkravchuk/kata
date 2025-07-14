namespace Kata.Common;

public interface IPriorityQueue<T> {
    void Insert(T item);
    T DeleteMax();
    bool IsEmpty { get; }
    int Size { get; }
}
