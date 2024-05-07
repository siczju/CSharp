/* fazer um programa para ler um número inteiro e uma matriz ordem N (N linhas N colunas) contendo contendo número inteiros, em seguida mostrar a diagonal principal e a quantidade de valores 
 valores negativos da matriz */

using System;

namespace Matriz
{
    class Program
    {
    static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            int valueNegative = 0;
            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' '); // tem q ser string pois so da pra usar .split com strings

                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]); 
                    if (int.Parse(values[j]) < 0)
                        valueNegative++;
                }
            }
                
                Console.Write("\nMain Diagonal: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(" " + mat[i,i]);
            }

            Console.WriteLine("\nValues negatives quantity: " + valueNegative); 
        }
    }
}