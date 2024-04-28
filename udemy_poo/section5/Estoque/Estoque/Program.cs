using System;
using System.Globalization;
namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            
            /*
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            //  Sintaxe Alternativa Para Inicializar Valores
            Produto p3 = new Produto() { 
                _nome = "TV",
                _preco = 500,
                _quantidade = 20
            };

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("\nDigite o número de produtos a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nDados do produto: " + p);

            Console.WriteLine("\nDigite o número de produtos a ser removido ao estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nDados do produto: " + p);
            */
            
        }
    }
}