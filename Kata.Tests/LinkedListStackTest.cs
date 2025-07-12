using Kata.Exercises;

namespace Kata.Tests;

public class LinkedListStackTest
{
    [Fact]
    public void TestStack()
    {
        var stack = new LinkedListStack<string>();
        Assert.Equal(0, stack.Size);

        stack.Push("world!");
        Assert.Equal(1, stack.Size);

        stack.Push(", ");
        Assert.Equal(2, stack.Size);

        stack.Push("blah");
        Assert.Equal(3, stack.Size);

        Assert.Equal("blah", stack.Pop());
        Assert.Equal(2, stack.Size);

        stack.Push("Hello");
        Assert.Equal(3, stack.Size);

        var str = string.Empty;
        while (!stack.IsEmpty)
            str += stack.Pop();

        Assert.Equal("Hello, world!", str);
    }
}
