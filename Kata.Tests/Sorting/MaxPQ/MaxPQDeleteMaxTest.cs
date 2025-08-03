using JetBrains.Annotations;
using Kata.Exercises.Sorting.MaxPQ;

namespace Kata.Tests.Sorting.MaxPQ;

[TestSubject(typeof(MaxPQDeleteMax<>))]
public class MaxPQDeleteMaxTest {
    [Fact]
    public void TestDeleteMax() {
        var queue = new MaxPQDeleteMax<string>(4);
        Assert.True(queue.IsEmpty);
        Assert.Equal(0, queue.Size);

        queue.Insert("K");
        queue.Insert("X");
        queue.Insert("G");
        queue.Insert("A");

        Assert.False(queue.IsEmpty);
        Assert.Equal(4, queue.Size);

        Assert.Equal("X", queue.DeleteMax());
        Assert.False(queue.IsEmpty);
        Assert.Equal(3, queue.Size);

        Assert.Equal("K", queue.DeleteMax());
        Assert.False(queue.IsEmpty);
        Assert.Equal(2, queue.Size);

        Assert.Equal("G", queue.DeleteMax());
        Assert.True(queue.IsEmpty);
        Assert.Equal(1, queue.Size);

        Assert.Equal("A", queue.DeleteMax());
        Assert.True(queue.IsEmpty);
        Assert.Equal(0, queue.Size);
    }
}
