using System;
using System.Collections.Generic;
using Graph.Classes;

namespace GetEdgeChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph.Classes.Graph graphItinerary = new Graph.Classes.Graph();

            Node Pandora = new Node();
            Pandora.Value = "Pandora";

            Node Arendelle = new Node();
            Arendelle.Value = "Arendelle";

            Node Metroville = new Node();
            Metroville.Value = "Metroville";

            Node Monstropolis = new Node();
            Monstropolis.Value = "Monstropolis";

            Node Narnia = new Node();
            Narnia.Value = "Narnia";

            Node Naboo = new Node();
            Naboo.Value = "Naboo";

            LinkedList<Tuple<Node, int>> originList = new LinkedList<Tuple<Node, int>>();
            Tuple<Node, int> origin = new Tuple<Node, int>(Pandora, 0);
            originList.AddFirst(origin);
            graphItinerary.AdjacencyList.AddFirst(originList);

            graphItinerary.AddEdge(Pandora, new Tuple<Node, int>(Arendelle, 150));
            graphItinerary.AddEdge(Pandora, new Tuple<Node, int>(Metroville, 82));

            graphItinerary.AddEdge(Arendelle, new Tuple<Node, int>(Metroville, 99));
            graphItinerary.AddEdge(Arendelle, new Tuple<Node, int>(Monstropolis, 42));

            graphItinerary.AddEdge(Monstropolis, new Tuple<Node, int>(Metroville, 105));
            graphItinerary.AddEdge(Monstropolis, new Tuple<Node, int>(Naboo, 73));

            graphItinerary.AddEdge(Naboo, new Tuple<Node, int>(Metroville, 26));
            graphItinerary.AddEdge(Naboo, new Tuple<Node, int>(Narnia, 250));

            graphItinerary.AddEdge(Narnia, new Tuple<Node, int>(Metroville, 37));

            Node[] cities = new Node[3] { Pandora, Metroville, Narnia };

            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"{cities[i].Value} ");
            }
            Console.WriteLine();
            var output = GetEdge(graphItinerary, cities);

            Console.WriteLine(output.Item1);
            Console.WriteLine(output.Item2);
            Console.ReadKey();
        }
        /// <summary>
        /// checks if direct flight is possible
        /// </summary>
        /// <param name="graph">graph of cities</param>
        /// <param name="cities">city iternary</param>
        /// <returns>tuple contain bool and string in money format</returns>
        public static Tuple<bool, string> GetEdge(Graph.Classes.Graph graph, Node[] cities)
        {
            if (cities.Length <= 1 || graph.AdjacencyList.Count == 0)
            {
                return new Tuple<bool, string>(false, 0.ToString("C2"));
            }

            int money = 0;
            bool exists = true;
            Tuple<bool, string> costs = new Tuple<bool, string> (exists, money.ToString("C2"));

            for (int i = 0; i < cities.Length-1; i++)
            {
                List<Tuple<Node, int>> neighborNodes = graph.GetNeighbors(cities[i]);
                foreach (var item in neighborNodes)
                {
                    exists = false;
                    if (item.Item1 == cities[i+1])
                    {
                        money += item.Item2;
                        exists = true;
                    }
                    if (exists)
                    {
                        break;
                    }
                }
                if (!exists)
                {
                    break;
                }
            }

            if (!exists)
            {
                return new Tuple<bool, string>(exists, 0.ToString("C2"));
            }
            else
            {
                return new Tuple<bool, string>(exists, money.ToString("C2"));
            }
        }
    }
}
