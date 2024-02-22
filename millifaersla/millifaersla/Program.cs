// See https://aka.ms/new-console-template for more information
class Program
{
    class Edge
    {
        public int Index { get; set; }
        public int Parent { get; set; }
        public int Length { get; set; }
        public List<Edge> Adjacent { get; set; } = new List<Edge>();
        public bool Visited { get; set; }

        public Edge(int index, int parent, int length)
        {
            Index = index;
            Parent = parent;
            Length = length;
        }
    }

    
    static void Main(string[] args)
    {
        int numBuildings = int.Parse(Console.ReadLine());
        List<(int, int, int)> edges = new List<(int, int, int)>();

        for (int i = 0; i < numBuildings - 1; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int length = int.Parse(input[2]);

            edges.Add((a, b, length));
        }

        List<Edge> tree = new List<Edge>();
        for (int i = 0; i < numBuildings; i++)
        {
            tree.Add(new Edge(i, -1, 0));
        }

        foreach (var edge in edges)
        {
            tree[edge.Item1 - 1].Adjacent.Add(tree[edge.Item2 - 1]);
            tree[edge.Item2 - 1].Adjacent.Add(tree[edge.Item1 - 1]);
            tree[edge.Item1 - 1].Length = edge.Item3;
            tree[edge.Item2 - 1].Length = edge.Item3;
        }

        int totalDistance = 0;
        Dfs(tree[0], -1, ref totalDistance);

        Console.WriteLine(totalDistance);
    }

    static void Dfs(Edge current, int parent, ref int totalDistance)
    {
        foreach (var adjacent in current.Adjacent)
        {
            if (adjacent.Parent == parent)
            {
                continue;
            }

            adjacent.Parent = current.Index;

            if (adjacent.Index == parent)
            {
                Dfs(adjacent, adjacent.Index, ref totalDistance);
            }
            else
            {
                totalDistance += adjacent.Length;
            }
        }
    }
} 
