using System.Globalization;
using ExercicioMetodoAbstrato.Entities;
using System.Reflection.Metadata;

namespace ExercicioMetodoAbstrato;
 class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of shapes: ");
        int n = int.Parse(Console.ReadLine());

        List<Shape> list = new List<Shape>();

        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine("Shape #" + i + " data:");
            Console.Write("Rectangle or Circle (r/c)? ");
            char choose = char.Parse(Console.ReadLine());
            
            Console.Write("Color (Black/Blue/Red): ");
            Color color = Enum.Parse<Color>(Console.ReadLine());
            
            if(choose == 'r') {
                Console.Write("Width: ");
                double width = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Height: ");
                double height = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Rectangle(width, height, color));
            }
            if(choose == 'c')
            {
                Console.Write("Radius: ");
                double radius = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Circle(radius, color));
            }
        }
        Console.WriteLine("\nSHAPE AREAS:");
        foreach(Shape shape in list)
        {
            Console.WriteLine(shape.Area().ToString("N2", CultureInfo.InvariantCulture));
        }
        
    }
}
