using Kata.Common;

namespace Kata.Solutions;

public class LinkedListStack<T> : IStack<T>
{
    private class Node
    {
        public required T Item;
        public Node? Next;
    }

    private Node? _first;

    public bool IsEmpty => _first == null;

    public int Size { get; private set; }

    public T Pop()
    {
        T item = _first!.Item;
        _first = _first.Next;
        Size--;
        return item;
    }

    public void Push(T item)
    {
        _first = new Node
        {
            Item = item,
            Next = _first,
        };
        Size++;
    }
}
