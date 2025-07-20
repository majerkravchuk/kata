using Kata.Exercises.SymbolTables.BinarySearchTree;

namespace Kata.Tests.SymbolTables.BinarySearchTree;

public class SetExerciseTest
{
    [Fact]
    public void TestSet()
    {
        var ex = new SetExercise<string, string>();

        ex.Set("D", "Dog");
        ex.Set("C", "Cat");
        ex.Set("D", "Donkey");

        Assert.Equal("Cat", ex.Get("C"));
        Assert.Equal("Donkey", ex.Get("D"));
        Assert.Null(ex.Get("X"));
    }
}
