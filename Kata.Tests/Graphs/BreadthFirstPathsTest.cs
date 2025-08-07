using JetBrains.Annotations;
using Kata.Exercises.Graphs;

namespace Kata.Tests.Graphs;

[TestSubject(typeof(BreadthFirstPaths))]
public class BreadthFirstPathsTest {
    private readonly BreadthFirstPaths _paths;

    public BreadthFirstPathsTest() {
        var graph = new BreadthFirstPaths.Graph(6);

        graph.Connect(0, 1);
        graph.Connect(0, 3);
        graph.Connect(3, 4);
        graph.Connect(1, 2);
        graph.Connect(2, 4);

        _paths = new BreadthFirstPaths(graph, 0);
    }

    [Fact]
    public void TestShortestPath() {
        Assert.Equal([0, 3, 4], _paths.ShortestPath(4));
    }

    [Fact]
    public void TestShortestPathToSelf() {
        Assert.Equal([0], _paths.ShortestPath(0));
    }

    [Fact]
    public void TestNoPath() {
        Assert.Null(_paths.ShortestPath(5));
    }
}
