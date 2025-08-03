```csharp
private static TValue? Get<TKey, TValue>(Node<TKey, TValue> tree, TKey key) 
    where TKey : IComparable<TKey>
{
    var node = tree;
    
    while (node != null)
    {
        var cmp = key.CompareTo(node.Key);
        if (cmp < 0) node = node.Left;
        else if (cmp > 0) node = node.Right;
        else return node.Value;
    }    
}
```
