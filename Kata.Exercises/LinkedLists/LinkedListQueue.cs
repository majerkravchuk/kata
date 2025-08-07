namespace Kata.Exercises.LinkedLists;

public class LinkedListQueue<T> {
    private class Node {
        public required T Value;
        public Node? Next;
    }

    private Node? _first;
    private Node? _last;

    public int Size { get; private set; }

    public void Enqueue(T value) {
        throw new NotImplementedException();
    }

    public T Dequeue() {
        throw new NotImplementedException();
    }
}
