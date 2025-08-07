namespace Kata.Exercises.LinkedLists;

public class LinkedListStack<T> {
    private class Node {
        public required T Value;
        public Node? Next;
    }

    private Node? _first;

    public int Size { get; private set; }

    public void Push(T value) {
        throw new NotImplementedException();
    }

    public T Pop() {
        throw new NotImplementedException();
    }
}
