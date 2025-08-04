using JetBrains.Annotations;
using Kata.Exercises.Sorting;
using Kata.Tests.Helpers;

namespace Kata.Tests.Sorting;

[TestSubject(typeof(QuickSort))]
public class QuickSortTest
{
    [Theory]
    [InlineData(new[] { 2, 1 })]
    [InlineData(new[] { 9, 3, 4 })]
    [InlineData(new[] { 9, 3, 7, 4, 69, 420, 42 })]
    public void TestSort(int[] array)
    {
        QuickSort.Sort(array);
        Assert.True(ArrayHelper.IsSorted(array));
    }

    [Fact]
    public void TestConsistentlyIncreasing()
    {
        var array = ArrayHelper.GetConsistentlyIncreasingArray(1000000);
        QuickSort.Sort(array);
        Assert.True(ArrayHelper.IsSorted(array));
    }

    [Fact]
    public void TestConsistentlyDecreasing()
    {
        var array = ArrayHelper.GetConsistentlyDecreasingArray(1000000);
        QuickSort.Sort(array);
        Assert.True(ArrayHelper.IsSorted(array));
    }
}
