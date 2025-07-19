using Kata.Exercises.SymbolTables.SequentialSearch;
using Xunit.Abstractions;

namespace Kata.Tests.SymbolTables.SequentialSearch;

public class SequentialSearchGetExerciseTest
{
    [Fact]
    public void TestGet()
    {
        var ex = new SequentialSearchGetExercise<string, string>();

        ex.Set("D", "Dog");
        ex.Set("C", "Cat");
        ex.Set("D", "Donkey");

        Assert.Equal("Cat", ex.Get("C"));
        Assert.Equal("Donkey", ex.Get("D"));
        Assert.Null(ex.Get("X"));
    }
}
