using Lista;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace Lista;
public class Program
{
    static void Main(string[] args)
    {
        List<Employee> listEmployee = new List<Employee>();

        Console.Write("How many employees will be registered? ");

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("\nEmployee #" + i + ":");
            Console.Write("\nId: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            listEmployee.Add(new Employee(id, name, salary));
        Console.WriteLine();
    }

    Console.Write("Enter the employee id that will have salary increase: ");
		int idEmployee = int.Parse(Console.ReadLine());

    Employee emplo = listEmployee.Find(x => x.Id == idEmployee);
		if(emplo != null){
    Console.WriteLine("Enter the percentage: ");
	double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emplo.IncreaseSalary(percentage);
    }
    else
    Console.WriteLine("This id does not exist!");

Console.WriteLine("\nUpdated list of employees: ");
foreach (Employee employees in listEmployee)
    Console.WriteLine(employees);
}
}
