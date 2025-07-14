using System.Collections;
using Kata.Common;

namespace Kata.Exercises;

public class LinkedListStack<T> : IStack<T>, IEnumerable<T> {
    public int Size => throw new NotImplementedException();

    public bool IsEmpty => throw new NotImplementedException();

    public IEnumerator<T> GetEnumerator() {
        throw new NotImplementedException();
    }

    public T Pop() {
        throw new NotImplementedException();
    }

    public void Push(T item) {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
