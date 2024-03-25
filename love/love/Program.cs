using System;
using System.Collections.Generic;
using System.Linq;

public class LoveDramaSolver
{
    // DFS to find cycles and classify them
    private static void DFS(int node, Dictionary<int, int> loveMap, bool[] visited, List<int> stack, HashSet<int> cycleNodes, ref bool foundCycle)
    {
        if (visited[node]) // If node is already visited, check if it forms a cycle
        {
            if (stack.Contains(node))
            {
                foundCycle = true;
                cycleNodes.UnionWith(stack.SkipWhile(x => x != node)); // Add nodes forming the cycle
            }
            return;
        }

        visited[node] = true;
        stack.Add(node);

        if (loveMap.ContainsKey(node)) // Continue DFS if the node loves someone
        {
            DFS(loveMap[node], loveMap, visited, stack, cycleNodes, ref foundCycle);
        }

        stack.RemoveAt(stack.Count - 1); // Backtrack
    }

    public static int CalculateMinimumArrows(Dictionary<int, int> loveMap)
    {
        bool[] visited = new bool[loveMap.Keys.Max() + 1];
        HashSet<int> cycleNodes = new HashSet<int>();
        int arrowsNeeded = 0;

        foreach (var node in loveMap.Keys)
        {
            if (!visited[node])
            {
                List<int> stack = new List<int>();
                bool foundCycle = false;
                DFS(node, loveMap, visited, stack, cycleNodes, ref foundCycle);

                // For each cycle found, increment arrow count
                if (foundCycle) arrowsNeeded++;
            }
        }

        // Add arrows for nodes not in a cycle (ensuring mutual love)
        int nodesNotInCycles = loveMap.Keys.Count - cycleNodes.Count;
        arrowsNeeded += nodesNotInCycles / 2; // Pair these nodes

        return arrowsNeeded;
    }

    public static void Main()
    {
        // Input processing
        int n = int.Parse(Console.ReadLine());
        int l = 0;
        Dictionary<int, int> loveMap = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            while ( n > l) {
                string[] lovePair = Console.ReadLine().Split();
                int a = ConvertNameToId(lovePair[0]);
                int b = ConvertNameToId(lovePair[1]);

                if (loveMap.ContainsKey(a))
                    loveMap[a] = b;
                else
                    loveMap.Add(a, b);
            }
            
        }

        int result = CalculateMinimumArrows(loveMap);
        Console.WriteLine(result);
    }

    // Helper method to convert name strings to unique integer IDs for easier processing
    private static int ConvertNameToId(string name)
    {
        // Implement this based on your requirements (e.g., hashing the name string)
        return name.GetHashCode();
    }
}

