namespace Kata.Exercises.Trees.BST;

public class BSTGet
{
    private static TValue? Get<TKey, TValue>(Node<TKey, TValue> tree, TKey key)
        where TKey : IComparable<TKey>
    {
        // ToDo: Implement Get method for BST here!
        return default;
    }

    #region Test

    private readonly Node<string, string> _root = new()
    {
        Key = "D",
        Value = "Donkey",
        Left = new Node<string, string>
        {
            Key = "C",
            Value = "Cat",
        },
        Right = new Node<string, string>
        {
            Key = "M",
            Value = "Mouse",
        }
    };

    [Theory]
    [InlineData("D", "Donkey")]
    [InlineData("C", "Cat")]
    [InlineData("M", "Mouse")]
    [InlineData("O", null)]
    public void TestGet(string key, string? expected)
    {
        Assert.Equal(expected, Get(_root, key));
    }

    #endregion

}
