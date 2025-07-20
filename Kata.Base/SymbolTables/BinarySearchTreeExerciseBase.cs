namespace Kata.Base.SymbolTables;

public class BinarySearchTreeExerciseBase<TKey, TValue> where TKey : IComparable<TKey>
{
    protected class Node
    {
        public required TKey Key;
        public required TValue Value;
        public Node? Left, Right;
        public int Size = 1;
    }

    protected Node? _root;

    public int Size => NodeSize(_root);

    public virtual TValue? Get(TKey key)
    {
        return GetFromSubTree(_root, key);
    }

    public virtual void Set(TKey key, TValue value)
    {
        _root = SetIntoSubTree(_root, key, value);
    }

    public virtual void DeleteMin()
    {
        _root = DeleteMinFromSubTree(_root!);
    }

    protected static Node? DeleteMinFromSubTree(Node node)
    {
        if (node.Left == null) return node.Right;
        node.Left = DeleteMinFromSubTree(node.Left);
        node.Size = NodeSize(node.Left) + 1 + NodeSize(node.Right);
        return node;
    }

    public TValue? Min()
    {
        return Min(_root!).Value;
    }

    protected static Node Min(Node node)
    {
        if (node.Left == null) return node;
        return Min(node.Left);
    }

    public virtual void Delete(TKey key)
    {
        _root = DeleteFromSubTree(_root, key);
    }

    private static Node? DeleteFromSubTree(Node? node, TKey key)
    {
        if (node == null) return null;

        var cmp = key.CompareTo(node.Key);
        if (cmp < 0) node.Left = DeleteFromSubTree(node.Left, key);
        else if (cmp > 0) node.Right = DeleteFromSubTree(node.Right, key);
        else
        {
            if (node.Right == null) return node.Left;
            if (node.Left == null) return node.Right;
            var t = node;
            node = Min(t.Right);
            node.Right = DeleteMinFromSubTree(t.Right);
            node.Left = t.Left;
        }
        node.Size = NodeSize(node.Left) + 1 + NodeSize(node.Right);
        return node;
    }

    protected static int NodeSize(Node? node)
    {
        return node?.Size ?? 0;
    }

    private static TValue? GetFromSubTree(Node? node, TKey key)
    {
        if (node == null) return default;
        var cmp = key.CompareTo(node.Key);
        if (cmp < 0) return GetFromSubTree(node.Left, key);
        if (cmp > 0) return GetFromSubTree(node.Right, key);
        return node.Value;
    }

    private static Node? SetIntoSubTree(Node? node, TKey key, TValue value)
    {
        if (node == null)
            return new Node { Key = key, Value = value, Size = 1 };

        var cmp = key.CompareTo(node.Key);
        if (cmp < 0) node.Left = SetIntoSubTree(node.Left, key, value);
        else if (cmp > 0) node.Right = SetIntoSubTree(node.Right, key, value);
        else node.Value = value;

        node.Size = NodeSize(node.Left) + 1 + NodeSize(node.Right);
        return node;
    }
}
