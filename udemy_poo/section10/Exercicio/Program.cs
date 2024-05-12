using System.Collections.Generic;
using Exercicio.Entities;

namespace Exercicio;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of employees: ");
        int NumEmployee = int.Parse(Console.ReadLine());

        List<Employee> listEmployee = new List<Employee>();

        for (int i = 1; i < NumEmployee + 1; i++)
        {
            Console.WriteLine("\nEmployee #" + i + " data:");
            Console.Write("OutSourced (y/n)? ");
            char choose = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine());

            if (choose == 'y')
            {
                Console.Write("Addtional charge: ");
                double addtionalCharge = double.Parse(Console.ReadLine());
                listEmployee.Add(new OutSourceEmployee(name, hours, valuePerHour, addtionalCharge));
            }
            else
                listEmployee.Add(new Employee(name, hours, valuePerHour));
        }
        Console.Write("\nPAYMENTS:");
        foreach (Employee emp in listEmployee)
        {
            Console.WriteLine(emp);
        }
    }
}