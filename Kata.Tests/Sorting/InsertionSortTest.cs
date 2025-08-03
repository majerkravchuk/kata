using JetBrains.Annotations;
using Kata.Exercises.Sorting;

namespace Kata.Tests.Sorting;

[TestSubject(typeof(InsertionSort))]
public class InsertionSortTest
{
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
    public void TestSort(int[] input, int[] sorted)
    {
        InsertionSort.Sort(input);
        Assert.Equal(sorted, input);
    }
}
