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
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="child"></param>
        public void AddEdge(Node parent, Tuple<Node, int> child)
        {
            bool listExists = false;
            foreach (var item in AdjacencyList)
            {
                var node = item.First.Value.Item1;
                if (node.Value == parent.Value)
                {
                    item.AddLast(child);
                }
                if (node.Value == child.Item1.Value)
                { 
                    item.AddLast(new Tuple<Node, int>(parent, child.Item2));
                    listExists = true;
                }
            }
            if (listExists == false || AdjacencyList.Count == 0)
            {
                LinkedList<Tuple<Node, int>> originList = new LinkedList<Tuple<Node, int>>();
                Tuple<Node, int> origin = new Tuple<Node, int>(child.Item1, 0);
                originList.AddFirst(origin);
                AdjacencyList.AddFirst(originList);
            }

        }
    }
}
