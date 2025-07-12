using System.Collections;
using Kata.Common;

namespace Kata.Exercises;

public class LinkedListQueue<T> : IQueue<T>, IEnumerable<T> {
    private class Node {
        public required T Item;
        public Node? Next;
    }

    private Node? _first;
    private Node? _last;

    public bool IsEmpty => _first == null;

    public int Size { get; private set; }

    public void Enqueue(T item) {
        var node = new Node { Item = item };
        if (IsEmpty) _first = node;
        else _last!.Next = node;
        _last = node;
        Size++;
    }

    public T Dequeue() {
        var item = _first!.Item;
        _first = _first.Next;
        if (IsEmpty) _last = null;
        Size--;
        return item;
    }

    public IEnumerator<T> GetEnumerator() {
        var current = _first;
        while (current != null) {
            var item = current.Item;
            current = current.Next;
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}
