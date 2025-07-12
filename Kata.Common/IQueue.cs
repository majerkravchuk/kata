namespace Kata.Common;

public interface IQueue<T> {
    void Enqueue(T item);
    T Dequeue();
    bool IsEmpty { get; }
    int Size { get; }
}
