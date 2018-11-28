using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Graph
    {
        public LinkedList<LinkedList<Tuple<Node, int>>> AdjacencyList { get; set; }

        public Graph()
        {
            AdjacencyList = new LinkedList<LinkedList<Tuple<Node, int>>>();
        }
        /// <summary>
        /// assumes graph is not empty and the parent node exists for the child node to be attached to
        /// finds the parent node and adds to the linked list
        /// if child node doesn't already exist, adds a new vertices to the graph
        /// </summary>
        /// <param name="parent">target node to attach to</param>
        /// <param name="child">node to attach</param>
        public void AddEdge(Node parent, Tuple<Node, int> child)
        {
            if (AdjacencyList.Count != 0)
            {
                bool parentExists = false;
                bool childExists = false;
                foreach (var item in AdjacencyList)
                {
                    var node = item.First.Value.Item1;
                    if (node.Value == parent.Value)
                    {
                        item.AddLast(child);
                        parentExists = true;
                    }
                    if (node.Value == child.Item1.Value)
                    {
                        item.AddLast(new Tuple<Node, int>(parent, child.Item2));
                        childExists = true;
                    }
                }
                if (childExists == false && parentExists == true)
                {
                    LinkedList<Tuple<Node, int>> originList = new LinkedList<Tuple<Node, int>>();
                    Tuple<Node, int> origin = new Tuple<Node, int>(child.Item1, 0);
                    Tuple<Node, int> parentAdd = new Tuple<Node, int>(parent, child.Item2);
                    originList.AddFirst(origin);
                    originList.AddLast(parentAdd);
                    AdjacencyList.AddLast(originList);
                }
            }
        }
        /// <summary>
        /// iterates 2 dimensionally through adjacency to collect the nodes
        /// </summary>
        /// <returns>list of all nodes in graph</returns>
        public List<Node> GetNodes()
        {
            List<Node> NodeList = new List<Node>();

            foreach (var yList in AdjacencyList)
            {
                foreach (var xList in yList)
                {
                    NodeList.Add(xList.Item1);
                }
            }

            return NodeList;
        }
        /// <summary>
        /// iterates through graph in y direction, finds the target node
        /// collects all connecting nodes in that linked list
        /// </summary>
        /// <param name="target">node to get neighbor nodes</param>
        /// <returns>list of neighbor nodes</returns>
        public List<Tuple<Node, int>> GetNeighbors(Node target)
        {
            List<Tuple<Node, int>> neighborNodes = new List<Tuple<Node, int>>();
            foreach (var item in AdjacencyList)
            {
                var node = item.First.Value.Item1;
                if (node.Value == target.Value)
                {
                    int count = 0;
                    foreach (var tuplesToAdd in item)
                    {
                        if (count > 0)
                        {
                            neighborNodes.Add(tuplesToAdd);
                        }
                        count++;
                    }
                }
            }
            return neighborNodes;
        }
        /// <summary>
        /// counts number of nodes in the y direction
        /// </summary>
        /// <returns>count of nodes</returns>
        public uint Size()
        {
            uint nodeCount = 0;

            foreach (var yList in AdjacencyList)
            {
                nodeCount++;

            }

            return nodeCount;
        }
    }
}
