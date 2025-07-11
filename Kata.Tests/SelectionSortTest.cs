using Kata.Exercises;

namespace Kata.Tests;

public class SelectionSortTest {
    private static readonly int[] sorted = [3, 4, 7, 9, 42, 69, 420];

    [Fact]
    public void TestSort() {
        var array = new int[] { 9, 3, 7, 4, 69, 420, 42 };
        SelectionSort.Sort(array);
        Assert.Equal(array, sorted);
    }
}
