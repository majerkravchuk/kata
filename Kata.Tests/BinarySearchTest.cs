using Kata.Exercises;

namespace Kata.Tests;

public class BinarySearchTest {
    private readonly int[] _array = [1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420];

    [Theory]
    [InlineData(69, 3)]
    [InlineData(1336, -1)]
    [InlineData(69420, 10)]
    [InlineData(69421, -1)]
    [InlineData(81, 5)]
    public void TestIndexOf(int value, int index) {
        Assert.Equal(index, BinarySearch.IndexOf(_array, value));
    }
}
