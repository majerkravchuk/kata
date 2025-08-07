using JetBrains.Annotations;
using Kata.Exercises.Sorting;
using Kata.Tests.Helpers;

namespace Kata.Tests.Sorting;

[TestSubject(typeof(SelectionSort))]
public class SelectionSortTest {
    [Theory]
    [InlineData(new[] { 2, 1 })]
    [InlineData(new[] { 9, 3, 4 })]
    [InlineData(new[] { 9, 3, 7, 4, 69, 420, 42 })]
    public void TestSort(int[] array) {
        SelectionSort.Sort(array);
        Assert.True(ArrayHelper.IsSorted(array));
    }
}
