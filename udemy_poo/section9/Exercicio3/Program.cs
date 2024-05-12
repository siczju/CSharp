using Exercicio3.Entities;

namespace Exercicio2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter cliente data:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Client client = new Client(name, email, date);

        Console.WriteLine("Enter order data: ");
        Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

        Order order = new Order(DateTime.Now, status, client);

        Console.Write("\nHow many items to this order? ");
        int numsItems = int.Parse(Console.ReadLine());

        for (int i = 0; i < numsItems; i++)
        {
            Console.WriteLine("\nEnter #" + i + " item data:");
            Console.Write("Product name: ");
            string productName = Console.ReadLine();
            Console.Write("Product price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            OrderItem item = new OrderItem(quantity, price, new Product(productName, price));
            order.AddItem(item);
        }

        Console.WriteLine("\n" + order);
    }
}