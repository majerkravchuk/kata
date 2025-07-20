using Kata.Exercises.SymbolTables.BinarySearchTree;

namespace Kata.Tests.SymbolTables.BinarySearchTree;

public class DeleteExercise
{
    [Fact]
    public void TestDelete()
    {
        var ex = new DeleteExercise<string, string>();

        ex.Set("K_Key", "K_Value");
        ex.Set("N_Key", "N_Value");
        ex.Set("H_Key", "H_Value");
        ex.Set("D_Key", "D_Value");
        ex.Set("Q_Key", "Q_Value");

        Assert.Equal("K_Value", ex.Get("K_Key"));
        Assert.Equal("N_Value", ex.Get("N_Key"));
        Assert.Equal("H_Value", ex.Get("H_Key"));
        Assert.Equal("D_Value", ex.Get("D_Key"));
        Assert.Equal("Q_Value", ex.Get("Q_Key"));
        Assert.Equal(5, ex.Size);

        ex.Delete("H_Key");
        Assert.Equal("K_Value", ex.Get("K_Key"));
        Assert.Equal("N_Value", ex.Get("N_Key"));
        Assert.Null(ex.Get("H_Key"));
        Assert.Equal("D_Value", ex.Get("D_Key"));
        Assert.Equal("Q_Value", ex.Get("Q_Key"));
        Assert.Equal(4, ex.Size);

        ex.Delete("N_Key");
        Assert.Equal("K_Value", ex.Get("K_Key"));
        Assert.Null(ex.Get("N_Key"));
        Assert.Null(ex.Get("H_Key"));
        Assert.Equal("D_Value", ex.Get("D_Key"));
        Assert.Equal("Q_Value", ex.Get("Q_Key"));
        Assert.Equal(3, ex.Size);

        ex.Delete("K_Key");
        Assert.Null(ex.Get("K_Key"));
        Assert.Null(ex.Get("N_Key"));
        Assert.Null(ex.Get("H_Key"));
        Assert.Equal("D_Value", ex.Get("D_Key"));
        Assert.Equal("Q_Value", ex.Get("Q_Key"));
        Assert.Equal(2, ex.Size);

        ex.Delete("Q_Key");
        Assert.Null(ex.Get("K_Key"));
        Assert.Null(ex.Get("N_Key"));
        Assert.Null(ex.Get("H_Key"));
        Assert.Equal("D_Value", ex.Get("D_Key"));
        Assert.Null(ex.Get("Q_Key"));
        Assert.Equal(1, ex.Size);

        ex.Delete("D_Key");
        Assert.Null(ex.Get("K_Key"));
        Assert.Null(ex.Get("N_Key"));
        Assert.Null(ex.Get("H_Key"));
        Assert.Null(ex.Get("D_Key"));
        Assert.Null(ex.Get("Q_Key"));
        Assert.Equal(0, ex.Size);
    }
}
