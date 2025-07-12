using System.Collections;
using Kata.Common;

namespace Kata.Solutions;

public class LinkedListBag<T> : IBag<T>, IEnumerable<T> {
    private class Node {
        public required T Item;
        public Node? Next;
    }

    private Node? _first;

    public bool IsEmpty => _first == null;

    public int Size { get; private set; }

    public void Add(T item) {
        _first = new Node {
            Item = item,
            Next = _first,
        };
        Size++;
    }

    public IEnumerator<T> GetEnumerator() {
        var current = _first;
        while (current != null) {
            var item = current.Item;
            current = current.Next;
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
