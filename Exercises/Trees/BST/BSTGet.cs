namespace Kata.Exercises.Trees.BST;

public class BSTGet {
    private static string? Get(string key) {
        // ToDo: Implement insertion sort here!
        return null;
    }

    #region Test

    private readonly Node<string, string> _root = new() {
        Key = "D",
        Value = "Donkey",
        Left = new Node<string, string> {
            Key = "C",
            Value = "Cat",
        },
        Right = new Node<string, string> {
            Key = "M",
            Value = "Mouser",
        }
    };

    [Theory]
    [InlineData("D", "Donkey")]
    [InlineData("C", "Cat")]
    [InlineData("M", "Mouse")]
    [InlineData("O", null)]
    public void TestGet(string key, string? expected)
    {
        Assert.Equal(expected, Get(key));
    }

    #endregion

}
