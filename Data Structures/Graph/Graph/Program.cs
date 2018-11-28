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

            Node child = new Node();
            child.Value = "B";

            graph.AddEdge(parent, new Tuple<Node, int>(child, 5));


            foreach (var item in graph.AdjacencyList)
            {
                Console.WriteLine(item.First.Value.Item1.Value);
            }
            Console.ReadKey();
        }
    }
}
