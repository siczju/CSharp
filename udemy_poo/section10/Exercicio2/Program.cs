
using Exercicio2.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio2;
class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        Console.Write("Enter the number of Products: ");
        int numProducts = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numProducts; i++)
        {
            Console.WriteLine("\nProduct #" + i + " data:");
            Console.Write("Common, used or imported (c/u/i)? ");
            char choose = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (choose == 'i')
            {
                Console.Write("Custom fee: ");
                double customFee = double.Parse(Console.ReadLine());
                list.Add(new ImportedProduct(name, price, customFee));
            }
            else if (choose == 'u')
            {
                Console.Write("Manufacture date (DD/MM/YYYY): ");
                DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                list.Add(new UsedProduct(name, price, manufactureDate));
            }
            else
                list.Add(new Product(name, price));
        }
        Console.WriteLine();
        foreach (Product product in list)
        {
            Console.WriteLine(product.PriceTag());
        }
    }
}