namespace Kata.Common;

public interface IStack<T> {
    void Push(T item);
    T Pop();
    bool IsEmpty { get; }
    int Size { get; }
}
