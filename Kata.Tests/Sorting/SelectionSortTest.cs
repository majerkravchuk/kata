using JetBrains.Annotations;
using Kata.Exercises.Sorting;

namespace Kata.Tests.Sorting;

[TestSubject(typeof(SelectionSort))]
public class SelectionSortTest {
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
    public void TestSort(int[] array, int[] expected) {
        SelectionSort.Sort(array);
        Assert.Equal(expected, array);
    }
}
