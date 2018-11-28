using System;
using Xunit;
using Graph.Classes;
using System.Collections.Generic;

namespace XUnitTestGraph
{
    public class UnitTest1
    {
        /// <summary>
        /// add b to a. check if b is added to A
        /// </summary>
        [Fact]
        public void AddEdgeTestBtoA()
        {
            Graph.Classes.Graph graph = new Graph.Classes.Graph();
            Node parent = new Node();
            parent.Value = "A";
            LinkedList<Tuple<Node, int>> originList = new LinkedList<Tuple<Node, int>>();
            Tuple<Node, int> origin = new Tuple<Node, int>(parent, 0);
            originList.AddFirst(origin);
            graph.AdjacencyList.AddFirst(originList);
            Node child = new Node();
            child.Value = "B";

            graph.AddEdge(parent, new Tuple<Node, int>(child, 5));

            Assert.Equal(child, graph.AdjacencyList.First.Value.Last.Value.Item1);
        }
        /// <summary>
        /// B node should exists as second LinkedList and be the first value in the list
        /// </summary>
        [Fact]
        public void AddEdgeTestBAddedtoLinkedList()
        {
            Graph.Classes.Graph graph = new Graph.Classes.Graph();
            Node parent = new Node();
            parent.Value = "A";
            LinkedList<Tuple<Node, int>> originList = new LinkedList<Tuple<Node, int>>();
            Tuple<Node, int> origin = new Tuple<Node, int>(parent, 0);
            originList.AddFirst(origin);
            graph.AdjacencyList.AddFirst(originList);
            Node child = new Node();
            child.Value = "B";

            graph.AddEdge(parent, new Tuple<Node, int>(child, 5));

            Assert.Equal(child, graph.AdjacencyList.Last.Value.First.Value.Item1);
        }
        /// <summary>
        /// A should be connected to B
        /// </summary>
        [Fact]
        public void AddEdgeTestBAddedtoA()
        {
            Graph.Classes.Graph graph = new Graph.Classes.Graph();
            Node parent = new Node();
            parent.Value = "A";
            LinkedList<Tuple<Node, int>> originList = new LinkedList<Tuple<Node, int>>();
            Tuple<Node, int> origin = new Tuple<Node, int>(parent, 0);
            originList.AddFirst(origin);
            graph.AdjacencyList.AddFirst(originList);
            Node child = new Node();
            child.Value = "B";

            graph.AddEdge(parent, new Tuple<Node, int>(child, 5));

            Assert.Equal(parent, graph.AdjacencyList.Last.Value.Last.Value.Item1);
        }
        /// <summary>
        /// Null test empty graph should do nothing
        /// </summary>
        [Fact]
        public void NullTest()
        {
            Graph.Classes.Graph graph = new Graph.Classes.Graph();
            Node parent = new Node();
            parent.Value = "A";

            Node child = new Node();
            child.Value = "B";

            graph.AddEdge(parent, new Tuple<Node, int>(child, 5));

            Assert.Empty(graph.AdjacencyList);
        }
        /// <summary>
        /// empty graph no nodes
        /// </summary>
        [Fact]
        public void GetNodesTestNull()
        {
            Graph.Classes.Graph graph = new Graph.Classes.Graph();
            var nodes = graph.GetNodes();
            Assert.Empty(nodes);
        }
        /// <summary>
        /// 3 nodes added should get a count of 3
        /// </summary>
        [Fact]
        public void GetNodesRegularTest()
        {
            Graph.Classes.Graph graph = new Graph.Classes.Graph();
            Node parent = new Node();
            parent.Value = "A";

            LinkedList<Tuple<Node, int>> originList = new LinkedList<Tuple<Node, int>>();
            Tuple<Node, int> origin = new Tuple<Node, int>(parent, 0);
            originList.AddFirst(origin);

            graph.AdjacencyList.AddFirst(originList);

            Node child = new Node();
            child.Value = "B";

            graph.AddEdge(parent, new Tuple<Node, int>(child, 5));

            Node c = new Node();
            c.Value = "C";

            graph.AddEdge(parent, new Tuple<Node, int>(c, 4));

            Assert.Equal(3, graph.AdjacencyList.Count);
        }

        /// <summary>
        /// print out of all nodes in the collection should match expected
        /// </summary>
        /// <param name="expected">expected node value</param>
        /// <param name="index">list index</param>
        [Theory]
        [InlineData("A", 0)]
        [InlineData("B", 1)]
        [InlineData("C", 2)]
        public void GetNodesCollectionTest(string expected, int index)
        {
            Graph.Classes.Graph graph = new Graph.Classes.Graph();
            Node parent = new Node();
            parent.Value = "A";

            LinkedList<Tuple<Node, int>> originList = new LinkedList<Tuple<Node, int>>();
            Tuple<Node, int> origin = new Tuple<Node, int>(parent, 0);
            originList.AddFirst(origin);

            graph.AdjacencyList.AddFirst(originList);

            Node child = new Node();
            child.Value = "B";

            graph.AddEdge(parent, new Tuple<Node, int>(child, 5));

            Node c = new Node();
            c.Value = "C";

            graph.AddEdge(parent, new Tuple<Node, int>(c, 4));

            var nodeList = graph.GetNodes();

            Assert.Equal(expected, nodeList[index].Value);
        }
        /// <summary>
        /// Null test neighbors shold be empty
        /// </summary>
        [Fact]
        public void NeighborsNullTest()
        {
            Graph.Classes.Graph graph = new Graph.Classes.Graph();
            Node parent = new Node();
            parent.Value = "A";

            var nodeList = graph.GetNeighbors(parent);

            Assert.Empty(nodeList);
        }
        /// <summary>
        /// Checks number of A neighbors: 2
        /// </summary>
        [Fact]
        public void NeighborsCountTest()
        {
            Graph.Classes.Graph graph = new Graph.Classes.Graph();
            Node parent = new Node();
            parent.Value = "A";

            LinkedList<Tuple<Node, int>> originList = new LinkedList<Tuple<Node, int>>();
            Tuple<Node, int> origin = new Tuple<Node, int>(parent, 0);
            originList.AddFirst(origin);

            graph.AdjacencyList.AddFirst(originList);

            Node child = new Node();
            child.Value = "B";

            graph.AddEdge(parent, new Tuple<Node, int>(child, 5));

            Node c = new Node();
            c.Value = "C";

            graph.AddEdge(parent, new Tuple<Node, int>(c, 4));

            var nodeList = graph.GetNeighbors(parent);

            Assert.Equal(2, nodeList.Count);
        }

        /// <summary>
        /// checks if values match
        /// </summary>
        /// <param name="expected">node value</param>
        /// <param name="index">list index</param>
        [Theory]
        [InlineData("B", 0)]
        [InlineData("C", 1)]
        public void GetNeigborsCollectionTest(string expected, int index)
        {
            Graph.Classes.Graph graph = new Graph.Classes.Graph();
            Node parent = new Node();
            parent.Value = "A";

            LinkedList<Tuple<Node, int>> originList = new LinkedList<Tuple<Node, int>>();
            Tuple<Node, int> origin = new Tuple<Node, int>(parent, 0);
            originList.AddFirst(origin);

            graph.AdjacencyList.AddFirst(originList);

            Node child = new Node();
            child.Value = "B";

            graph.AddEdge(parent, new Tuple<Node, int>(child, 5));

            Node c = new Node();
            c.Value = "C";

            graph.AddEdge(parent, new Tuple<Node, int>(c, 4));

            var nodeList = graph.GetNeighbors(parent);

            Assert.Equal(expected, nodeList[index].Item1.Value);
        }
        /// <summary>
        /// size of empty graph 0
        /// </summary>
        [Fact]
        public void NullSizeTest()
        {
            Graph.Classes.Graph graph = new Graph.Classes.Graph();

            int count = graph.Size();

            Assert.Equal(0, count);
        }


        /// <summary>
        /// checks size of graph for 3 nodes
        /// </summary>
        [Fact]
        public void SizeTest()
        {
            Graph.Classes.Graph graph = new Graph.Classes.Graph();
            Node parent = new Node();
            parent.Value = "A";

            LinkedList<Tuple<Node, int>> originList = new LinkedList<Tuple<Node, int>>();
            Tuple<Node, int> origin = new Tuple<Node, int>(parent, 0);
            originList.AddFirst(origin);

            graph.AdjacencyList.AddFirst(originList);

            Node child = new Node();
            child.Value = "B";

            graph.AddEdge(parent, new Tuple<Node, int>(child, 5));

            Node c = new Node();
            c.Value = "C";

            graph.AddEdge(parent, new Tuple<Node, int>(c, 4));

            int count = graph.Size();

            Assert.Equal(3, count);
        }

        /// <summary>
        /// checks for 10 nodes
        /// </summary>
        [Fact]
        public void SizeTestLarge()
        {
            Graph.Classes.Graph graph = new Graph.Classes.Graph();
            Node parent = new Node();
            parent.Value = "A";

            LinkedList<Tuple<Node, int>> originList = new LinkedList<Tuple<Node, int>>();
            Tuple<Node, int> origin = new Tuple<Node, int>(parent, 0);
            originList.AddFirst(origin);

            graph.AdjacencyList.AddFirst(originList);

            Node child = new Node();
            child.Value = "B";

            graph.AddEdge(parent, new Tuple<Node, int>(child, 5));

            Node c = new Node();
            c.Value = "C";

            Node d = new Node();
            d.Value = "D";

            Node e = new Node();
            e.Value = "E";

            Node f = new Node();
            f.Value = "F";

            Node g = new Node();
            g.Value = "G";

            Node h = new Node();
            h.Value = "H";

            Node i = new Node();
            i.Value = "I";

            Node j = new Node();
            j.Value = "J";

            graph.AddEdge(parent, new Tuple<Node, int>(c, 4));
            graph.AddEdge(parent, new Tuple<Node, int>(d, 4));
            graph.AddEdge(parent, new Tuple<Node, int>(e, 4));
            graph.AddEdge(parent, new Tuple<Node, int>(f, 4));
            graph.AddEdge(parent, new Tuple<Node, int>(g, 4));
            graph.AddEdge(parent, new Tuple<Node, int>(h, 4));
            graph.AddEdge(parent, new Tuple<Node, int>(i, 4));
            graph.AddEdge(parent, new Tuple<Node, int>(j, 4));

            int count = graph.Size();

            Assert.Equal(10, count);
        }
    }
}
