```c#
public class BreadthFirstPaths
{
    public class Graph
    {
        private readonly List<LinkedList<int>> _adjacents;

        public int Size { get; }

        public Graph(int size)
        {
            Size = size;
            _adjacents = new List<LinkedList<int>>(size);
            for (var i = 0; i < size; i++)
                _adjacents.Add(new LinkedList<int>());
        }

        public void Connect(int v, int w)
        {
            _adjacents[v].AddFirst(w);
            _adjacents[w].AddFirst(v);
        }

        public IEnumerable<int> Adjacents(int v) => _adjacents[v];
    }

    private readonly int _source;
    private readonly bool[] _visited;
    private readonly int[] _edgeTo;

    public BreadthFirstPaths(Graph graph, int source)
    {
        _source = source;
        _visited = new bool[graph.Size];
        _edgeTo = new int[graph.Size];

        BreadthFirstSearch(graph, source);
    }

    public IEnumerable<int>? ShortestPath(int target)
    {
        throw new NotImplementedException();
    }

    private void BreadthFirstSearch(Graph graph, int source)
    {
        throw new NotImplementedException();
    }
}
```
