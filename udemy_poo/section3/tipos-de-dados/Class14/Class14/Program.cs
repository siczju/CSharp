//      Tipos básicos em C#
// unsigned -> so numero positivo
// signed -> dividido por 2, pois metade é negativo e metade a positivo: -128 a 127
using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            string person1 = "Maria";

            Console.WriteLine(x);
            Console.WriteLine(person1);
            
            Console.WriteLine(int.MinValue); // ver o minimo valor que o int pode armazenar
            Console.WriteLine(int.MaxValue); // ver o maximo valor que o int pode armazenar  

        }
    }
}