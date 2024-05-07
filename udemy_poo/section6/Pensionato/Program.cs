using System;

namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] quartos = new Estudante[10];

            Console.Write("Quantos quartos serão alugados?: ");
            int n = int.Parse(Console.ReadLine());

  

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nAluguel #" + i + 1);
                Console.Write(" Nome: ");
                string nome = Console.ReadLine();
                Console.Write(" Email: ");
                string email = Console.ReadLine();
                Console.Write(" Quarto (0-9): ");
                int quarto = int.Parse(Console.ReadLine());
                quartos[quarto] = new Estudante(nome, email, quarto);
            }

            Console.WriteLine("\nQuartos ocupados:");
            for(int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                    Console.WriteLine(" " + quartos[i]);
            }
            
        }
    }
}