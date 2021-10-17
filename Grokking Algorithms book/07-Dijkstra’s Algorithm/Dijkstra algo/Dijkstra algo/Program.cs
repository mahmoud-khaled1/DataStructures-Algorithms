using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_algo
{
    class Program
    {
        private static Dictionary<string, Dictionary<string, double>> _graph =
            new Dictionary<string, Dictionary<string, double>>();
        private static List<string> _processed = new List<string>();
        private const double _infinity = double.PositiveInfinity;


        static void Main(string[] args)
        {
            //You learn Dijkstra’s algorithm, which lets you
            //answer “What’s the shortest path to X?” for
            //weighted graphs.
            //Dijkstra’s algorithm works when all the weights are positive.
            //If you have negative weights, use the Bellman-Ford algorithm.
            //------------------------------------------------------------

            // 1- create the graph 
            _graph.Add("start", new Dictionary<string, double>());
            _graph["start"].Add("a", 6.0);
            _graph["start"].Add("b", 2.0);

            _graph.Add("a", new Dictionary<string, double>());
            _graph["a"].Add("fin", 1.0);

            _graph.Add("b", new Dictionary<string, double>());
            _graph["b"].Add("a", 3.0);
            _graph["b"].Add("fin", 5.0);

            _graph.Add("fin", new Dictionary<string, double>());

            //2- create Dictionary of costs of graph .
            var costs = new Dictionary<string, double>();
            costs.Add("a", 6.0);
            costs.Add("b", 2.0);
            costs.Add("fin", _infinity);

            //3-create Dictionary of parent ;
            var parents = new Dictionary<string, string>();
            parents.Add("a", "start");
            parents.Add("b", "start");
            parents.Add("fin", null);

            var node = FindLowestCostNode(costs);
            while (node != null)
            {
                var cost = costs[node];
                var neighbors = _graph[node];
                foreach (var n in neighbors.Keys)
                {
                    var new_cost = cost + neighbors[n];
                    if (costs[n] > new_cost)
                    {
                        costs[n] = new_cost;
                        parents[n] = node;
                    }
                }
                _processed.Add(node);
                node = FindLowestCostNode(costs);
            }
            Console.WriteLine(string.Join(", ", costs));
        }
        private static string FindLowestCostNode(Dictionary<string, double> costs)
        {
            var lowestCost = double.PositiveInfinity;
            string lowestCostNode = null;
            foreach (var node in costs)
            {
                var cost = node.Value;
                if (cost < lowestCost && !_processed.Contains(node.Key))
                {
                    lowestCost = cost;
                    lowestCostNode = node.Key;
                }
            }
            return lowestCostNode;
        }
    }
}
