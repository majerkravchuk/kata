using JetBrains.Annotations;
using Kata.Exercises.LinkedLists;

namespace Kata.Tests.LinkedLists;

[TestSubject(typeof(LinkedListStack<>))]
public class LinkedListStackTest
{
    [Fact]
    public void TestStack()
    {
        var stack = new LinkedListStack<string>();
        Assert.Equal(0, stack.Size);

        stack.Push("A");
        stack.Push("B");
        stack.Push("C");

        Assert.Equal("C", stack.Pop());
        Assert.Equal("B", stack.Pop());
        Assert.Equal("A", stack.Pop());

        Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }
}
