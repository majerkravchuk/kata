using System.Collections;
using Kata.Common;

namespace Kata.Exercises;

public class LinkedListQueue<T> : IQueue<T>, IEnumerable<T> {
    public bool IsEmpty => throw new NotImplementedException();

    public int Size => throw new NotImplementedException();

    public T Dequeue() {
        throw new NotImplementedException();
    }

    public void Enqueue(T item) {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator() {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
