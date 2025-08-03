using JetBrains.Annotations;
using Kata.Exercises.Sorting;

namespace Kata.Tests.Sorting;

// A B C D E F G H I J K L M N O P Q R S T U V W X Y Z

[TestSubject(typeof(MaxPQ<>))]
public class MaxPQTest {
    [Fact]
    public void TestMaxPQ() {
        var queue = new MaxPQ<string>(4);
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
