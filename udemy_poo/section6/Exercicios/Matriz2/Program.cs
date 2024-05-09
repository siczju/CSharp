using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the lines for matrix: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Type the columns for matrix: ");
            int c = int.Parse(Console.ReadLine());
            int[,] mat = new int[l, c];

            for (int i = 0; i < l; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++)
                    mat[i, j] = int.Parse(values[j]);
            }
            Console.WriteLine("Enter a number to show values in right, left, top and bottom of it");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine(x + " in position (" + i + "," + j + ")");
                        if (j > 0)
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        if (i > 0)
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        if (j < c - 1)
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        if (i < l - 1)
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                    }
                }
            }
        }
    }
}
