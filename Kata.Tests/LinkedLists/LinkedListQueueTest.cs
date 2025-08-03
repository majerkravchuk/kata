using JetBrains.Annotations;
using Kata.Exercises.LinkedLists;

namespace Kata.Tests.LinkedLists;

[TestSubject(typeof(LinkedListQueue<>))]
public class LinkedListQueueTest {
    [Fact]
    public void TestQueue() {
        var queue = new LinkedListQueue<string>();
        Assert.Equal(0, queue.Size);

        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");

        Assert.Equal("A", queue.Dequeue());
        Assert.Equal("B", queue.Dequeue());
        Assert.Equal("C", queue.Dequeue());

        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
    }
}
