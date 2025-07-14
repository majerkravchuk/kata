namespace Kata.Common;

public interface IStack<T> {
    void Push(T item);
    T Pop();
    int Size { get; }
    bool IsEmpty { get; }
}
