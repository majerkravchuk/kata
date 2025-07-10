using Kata.Exercises;

namespace Kata.Tests;

public class BinarySearchTest {
    [Fact]
    public void TestIndexOf() {
        var array = new[] { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 };

        Assert.Equal(3, BinarySearch.IndexOf(array, 69));
        Assert.Equal(-1, BinarySearch.IndexOf(array, 1336));
        Assert.Equal(10, BinarySearch.IndexOf(array, 69420));
        Assert.Equal(-1, BinarySearch.IndexOf(array, 69421));
    }
}
