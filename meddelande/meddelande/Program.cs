using System;
using System.Collections.Generic;

namespace SquareMessage
{
    class Program
    {
        static string FindMessage(char[,] grid)
        {
            // Initialize the message
            string message = "";

            // Initialize the visited array
            bool[,] visited = new bool[grid.GetLength(0), grid.GetLength(1)];

            // Start from the upper-left corner
            int i = 0;
            int j = 0;
            visited[i, j] = true;

            // Traverse the grid using DFS
            while (i < grid.GetLength(0) - 1 || j < grid.GetLength(1) - 1)
            {
                // Move downward
                if (i < grid.GetLength(0) - 1 && !visited[i + 1, j])
                {
                    i++;
                    visited[i, j] = true;
                    message += grid[i, j];
                }
                // Move right
                else if (j < grid.GetLength(1) - 1 && !visited[i, j + 1])
                {
                    j++;
                    visited[i, j] = true;
                    message += grid[i, j];
                }
            }

            return message;
        }

        static void Main(string[] args)
        {
            // Read the number of rows and columns
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            // Initialize the grid
            char[,] grid = new char[n, m];
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for