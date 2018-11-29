using System;
using Xunit;
using Graph.Classes;
using static GetEdgeChallenge.Program;
using System.Collections.Generic;

namespace XUnitTestGetEdge
{
    public class UnitTest1
    {
        /// <summary>
        /// direct flights available according to challenge model
        /// </summary>
        [Fact]
        public void GetEdgeTestTrue()
        {
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
            var output = GetEdge(graphItinerary, cities);

            Assert.True(output.Item1);
        }
        /// <summary>
        /// get costs of the trip
        /// </summary>
        [Fact]
        public void GetEdgeTestMoney()
        {
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
            var output = GetEdge(graphItinerary, cities);

            Assert.Equal("$119.00", output.Item2);
        }

        /// <summary>
        /// direct flights not available
        /// </summary>
        [Fact]
        public void GetEdgeTestFalse()
        {
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

            Node[] cities = new Node[3] { Metroville, Narnia, Pandora};
            var output = GetEdge(graphItinerary, cities);

            Assert.False(output.Item1);
        }

        /// <summary>
        /// same cities - no flights so false
        /// </summary>
        [Fact]
        public void GetEdgeTestSameCities()
        {
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

            Node[] cities = new Node[3] { Narnia, Narnia, Narnia };
            var output = GetEdge(graphItinerary, cities);

            Assert.False(output.Item1);
        }
        /// <summary>
        /// array size of zero
        /// </summary>
        [Fact]
        public void GetEdgeNullCities()
        {
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

            Node[] cities = new Node[0];
            var output = GetEdge(graphItinerary, cities);

            Assert.False(output.Item1);
        }
    }
}
