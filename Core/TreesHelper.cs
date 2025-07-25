namespace Kata.Core;

public static class TreesHelper
{
    public class Node<TKey, TValue> where TKey : IComparable<TKey>
    {
        public required TKey Key;
        public required TValue Value;
        public Node<TKey, TValue>? Left, Right;
        public int Size = 1;
    }
}
