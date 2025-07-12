using Kata.Exercises;

namespace Kata.Tests;

public class LinkedListBagTest {
    [Fact]
    public void TestAdd() {
        var bag = new LinkedListBag<string>();
        Assert.Equal(0, bag.Size);

        bag.Add("Hello");
        bag.Add(", ");
        bag.Add("world!");

        Assert.Equal(3, bag.Size);
        Assert.False(bag.IsEmpty);
    }

    [Fact]
    public void TestEnumareble() {
        var items = new List<string> { "A", "B", "B", "C" };

        var bag = new LinkedListBag<string>();

        foreach (var item in items)
            bag.Add(item);

        Assert.Equal(4, bag.Size);

        foreach (var item in bag)
            items.Remove(item);

        Assert.Empty(items);
    }
}
