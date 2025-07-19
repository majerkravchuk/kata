using Kata.Exercises.SymbolTables.SequentialSearch;

namespace Kata.Tests.SymbolTables.SequentialSearch;

public class SequentialSearchSymbolTableExerciseGetTest
{
    [Fact]
    public void TestGet()
    {
        var ex = new SequentialSearchSymbolTableExerciseGet<string, string>();

        ex.Set("D", "Dog");
        ex.Set("C", "Cat");
        ex.Set("D", "Donkey");

        Assert.Equal("Cat", ex.Get("C"));
        Assert.Equal("Donkey", ex.Get("D"));
        Assert.Null(ex.Get("X"));
    }
}
