using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int[] findTheBug(string[] grid)
        {
            // Complete this function
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 'X')
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1, -1 };
        }
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] grid = new string[n];
            for (int grid_i = 0; grid_i < n; grid_i++)
            {
                grid[grid_i] = Console.ReadLine();
            }
            // Return an array containing [r, c]
            int[] result = findTheBug(grid);
            Console.WriteLine(String.Join(",", result));
        }

    }

}
