namespace Kata.Common;

public interface IQueue<T> {
    void Enqueue(T item);
    T Dequeue();
    int Size { get; }
    bool IsEmpty { get; }
}
