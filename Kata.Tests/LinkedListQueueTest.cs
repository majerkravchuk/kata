using Kata.Exercises;

namespace Kata.Tests;

public class LinkedListQueueTest {
    private const string Expected = "Hello, world!";

    [Fact]
    public void TestEnqueueAndDequeue() {
        var queue = new LinkedListQueue<string>();
        Assert.Equal(0, queue.Size);

        queue.Enqueue("blah");
        Assert.Equal(1, queue.Size);

        Assert.Equal("blah", queue.Dequeue());
        Assert.Equal(0, queue.Size);

        queue.Enqueue("Hello");
        Assert.Equal(1, queue.Size);

        queue.Enqueue(", ");
        Assert.Equal(2, queue.Size);

        queue.Enqueue("world!");
        Assert.Equal(3, queue.Size);

        var str = string.Empty;
        while (!queue.IsEmpty)
            str += queue.Dequeue();

        Assert.Equal(Expected, str);
    }

    [Fact]
    public void TestEnumareble() {
        var queue = new LinkedListQueue<string>();
        queue.Enqueue("Hello");
        queue.Enqueue(", ");
        queue.Enqueue("world!");
        Assert.Equal(Expected, string.Join("", queue));
    }
}
