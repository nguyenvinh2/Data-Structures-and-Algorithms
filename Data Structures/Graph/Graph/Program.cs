using System;
using System.Collections.Generic;
using Graph.Classes;

namespace Graph
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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


            foreach (var item in graph.AdjacencyList)
            {
                foreach (var node in item)
                {
                    Console.Write(node.Item2);
                    Console.WriteLine(node.Item1.Value);
                }
            }

            var nodeList = graph.GetNodes();

            foreach (var item in nodeList)
            {
                Console.Write(item.Value);
            }

            var neighbor = graph.GetNeighbors(parent);

            foreach (var item in neighbor)
            {
                Console.Write(item.Item1.Value);
                Console.WriteLine(item.Item2);
            }

            var count = graph.Size();

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
