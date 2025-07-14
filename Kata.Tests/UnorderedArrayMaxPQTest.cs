using Kata.Exercises;

namespace Kata.Tests;

public class UnorderedArrayMaxPQTest {
    [Fact]
    public void TestPQ() {
        var queue = new UnorderedArrayMaxPQ<string>(3);
        Assert.True(queue.IsEmpty);
        Assert.Equal(0, queue.Size);

        queue.Insert("A");
        queue.Insert("C");
        queue.Insert("B");

        Assert.False(queue.IsEmpty);
        Assert.Equal(3, queue.Size);

        Assert.Equal("C", queue.DeleteMax());
        Assert.Equal("B", queue.DeleteMax());
        Assert.Equal("A", queue.DeleteMax());

        Assert.True(queue.IsEmpty);
        Assert.Equal(0, queue.Size);
    }
}
