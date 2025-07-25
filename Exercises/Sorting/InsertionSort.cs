namespace Kata.Exercises.Sorting;

public class InsertionSort
{
    private static void Sort<T>(T[] array) where T : IComparable<T>
    {
        // ToDo: Implement insertion sort here!
    }

    #region Test

    [Theory]
    [InlineData(
        new[] { 2, 1 },
        new[] { 1, 2 })]
    [InlineData(
        new[] { 9, 3, 4 },
        new[] { 3, 4, 9 })]
    [InlineData(
        new[] { 9, 3, 7, 4, 69, 420, 42 },
        new[] { 3, 4, 7, 9, 42, 69, 420 })]
    public void TestSort(int[] input, int[] expected)
    {
        Sort(input);
        Assert.Equal(input, expected);
    }

    #endregion
}
