using System.Collections;
using Kata.Common;

namespace Kata.Exercises;

public class LinkedListBag<T> : IBag<T>, IEnumerable<T> {
    public int Size => throw new NotImplementedException();

    public bool IsEmpty => throw new NotImplementedException();

    public void Add(T item) {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator() {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
