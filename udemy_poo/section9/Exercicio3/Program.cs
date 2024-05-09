using Exercicio3.Entities;

namespace Exercicio2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("\nEmail: ");
        string email = Console.ReadLine();
        Console.Write("\nBirth date (DD/MM/YYYY): ");
        string date = Console.ReadLine();

        Console.WriteLine("\nEnter order data: ");
        Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
        Console.Write("\nHow many items to this order? ");

        Console.WriteLine("Enter #1 item data:");
        Console.Write("\nProduct name: ");
        Console.Write("\nProduct price: ");
        Console.Write("\nQuantity: ");
    }
}