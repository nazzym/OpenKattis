using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
    static HashSet<int> visited = new HashSet<int>();
    static HashSet<int> explored = new HashSet<int>();
    static Stack<int> order = new Stack<int>();
    static bool impossible = false;

    static void DFS(int node)
    {
        if (explored.Contains(node)) return;
        if (visited.Contains(node))
        {
            impossible = true;
            return;
        }

        visited.Add(node);
        foreach (var neighbor in graph.GetValueOrDefault(node, new List<int>()))
        {
            DFS(neighbor);
        }
        visited.Remove(node);
        explored.Add(node);
        order.Push(node);
    }

    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = input[0], m = input[1];

        for (int i = 0; i < m; i++)
        {
            var dependency = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (!graph.ContainsKey(dependency[0]))
                graph[dependency[0]] = new List<int>();
            graph[dependency[0]].Add(dependency[1]);
        }

        for (int i = 1; i <= n; i++)
        {
            if (!explored.Contains(i))
                DFS(i);
        }

        if (impossible)
            Console.WriteLine("IMPOSSIBLE");
        else
        {
            while (order.Count > 0)
                Console.WriteLine(order.Pop());
        }
    }
}

