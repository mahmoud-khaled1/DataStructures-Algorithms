using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    class Program
    {
        private static  Dictionary<string, string[]> graph = new Dictionary<string, string[]>();
        static void Main(string[] args)
        {
            //Breadth-first search allows you to find the shortest distance between two things.
            //Breadth-first search tells you if there’s a path from A to B.
            //If there’s a path, breadth-first search will find the shortest path.
            //If you have a problem like “find the shortest X,” try modeling your
            //problem as a graph, and use breadth - first search to solve.

           
            graph.Add("you", new[] { "alice", "bob", "claire" });
            graph.Add("bob", new[] { "anuj", "peggy" });
            graph.Add("alice", new[] { "peggy" });
            graph.Add("claire", new[] { "thom", "jonny" });
            graph.Add("anuj", Array.Empty<string>());
            graph.Add("peggy", Array.Empty<string>());
            graph.Add("thom", Array.Empty<string>());
            graph.Add("jonny", Array.Empty<string>());

            Console.WriteLine(BFS_Search("you"));
           

        }
        private static string BFS_Search(string name)
        {
            var searchQueue = new Queue<string>(graph[name]); // to search over all nighbours of name
            var searched = new List<string>(); // to append visited node
            while(searchQueue.Any())
            {
                var person = searchQueue.Dequeue();
                if(!searched.Contains(person))
                {
                    if(personIsSeller(person))
                    {
                        return $"{person} is mango seller";
                    }
                    else
                    {
                        searchQueue = new Queue<string>(searchQueue.Concat(graph[person]));
                        searched.Add(person);
                    }
                }
            }
            return "There is no mango seller !";
        }
        private static bool personIsSeller(string name)
        {
            return name.EndsWith("m");
        }
    }
}
