namespace Kata.Exercises.Arrays;

public class BinarySearch {
    private static int IndexOf<T>(T[] array, T value) where T : IComparable<T> {
        // ToDo: Implement binary search here!
        return -1;
    }

    #region Test

    private readonly int[] _array = [1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420];

    [Theory]
    [InlineData(69, 3)]
    [InlineData(1336, -1)]
    [InlineData(69420, 10)]
    [InlineData(69421, -1)]
    [InlineData(81, 5)]
    public void TestIndexOf(int value, int index)
    {
        Assert.Equal(index, IndexOf(_array, value));
    }

    #endregion
}
