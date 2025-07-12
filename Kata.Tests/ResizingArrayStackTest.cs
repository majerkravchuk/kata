using Kata.Exercises;

namespace Kata.Tests;

public class ResizingArrayStackTest {
    [Fact]
    public void TestStack() {
        var stack = new ResizingArrayStack<string>();
        Assert.Equal(0, stack.Size);
        Assert.Equal(1, stack.Capacity);

        stack.Push("world!");
        Assert.Equal(1, stack.Size);
        Assert.Equal(1, stack.Capacity);

        stack.Push(", ");
        Assert.Equal(2, stack.Size);
        Assert.Equal(2, stack.Capacity);

        stack.Push("blah");
        Assert.Equal(3, stack.Size);
        Assert.Equal(4, stack.Capacity);

        Assert.Equal("blah", stack.Pop());
        Assert.Equal(2, stack.Size);
        Assert.Equal(4, stack.Capacity);

        stack.Push("Hello");
        Assert.Equal(3, stack.Size);
        Assert.Equal(4, stack.Capacity);

        var str = string.Empty;
        while (!stack.IsEmpty)
            str += stack.Pop();

        Assert.Equal("Hello, world!", str);

        Assert.Equal(2, stack.Capacity);
    }
}
