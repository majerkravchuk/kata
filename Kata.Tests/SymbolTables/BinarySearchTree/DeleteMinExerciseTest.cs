using Kata.Exercises.SymbolTables.BinarySearchTree;

namespace Kata.Tests.SymbolTables.BinarySearchTree;

public class DeleteMinExercise
{
    [Fact]
    public void TestDeleteMin()
    {
        var ex = new DeleteMinExercise<string, string>();

        ex.Set("K", "K");
        ex.Set("N", "N");
        ex.Set("H", "H");
        ex.Set("D", "D");
        ex.Set("Q", "Q");

        Assert.Equal("D", ex.Min());
        Assert.Equal(5, ex.Size);

        ex.DeleteMin();
        Assert.Null(ex.Get("D"));
        Assert.Equal("H", ex.Min());
        Assert.Equal(4, ex.Size);

        ex.DeleteMin();
        Assert.Null(ex.Get("H"));
        Assert.Equal("K", ex.Min());
        Assert.Equal(3, ex.Size);

        ex.DeleteMin();
        Assert.Null(ex.Get("K"));
        Assert.Equal("N", ex.Min());
        Assert.Equal(2, ex.Size);

        ex.DeleteMin();
        Assert.Null(ex.Get("N"));
        Assert.Equal("Q", ex.Min());
        Assert.Equal(1, ex.Size);

        ex.DeleteMin();
        Assert.Null(ex.Get("Q"));
        Assert.Null(ex.Min());
        Assert.Equal(0, ex.Size);
    }
}
