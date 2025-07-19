using Kata.Exercises.Sorting;

namespace Kata.Tests.Sorting;

public class InsertionSortExerciseTest {
    private static readonly int[] sorted = [3, 4, 7, 9, 42, 69, 420];

    [Fact]
    public void TestSort() {
        var ex = new SelectionSortExercise();
        var array = new int[] { 9, 3, 7, 4, 69, 420, 42 };
        ex.Sort(array);
        Assert.Equal(array, sorted);
    }
}
