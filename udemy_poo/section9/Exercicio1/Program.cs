/*
    Exercicio: Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar do usuário um mês e mostrar qual foi o salario do 
    funcionario nesse mês.
 */

using System.Globalization;
namespace Exercicio1.Entities;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter department's name: ");
        string DeptName = Console.ReadLine();

        Console.Write("\nEnter worker data: ");

        Console.Write("\nName: ");
        string name = Console.ReadLine();

        Console.Write("\nLevel (Junior/MidLevel/Senior: ");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

        Console.Write("\nBase salary: ");
        double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Department departamento = new Department(DeptName);

        Worker worker = new Worker(name, level, baseSalary, departamento);

        Console.Write("\nHow many contracts to this worker? ");
        int numOfContracts = int.Parse(Console.ReadLine());


        for(int i = 0; i < numOfContracts; i++)
        {

        Console.WriteLine("\nEnter #" + (i + 1) + " contract data: ");

        Console.Write("\nDate (DD/MM/YYYY): ");
        DateTime Date = DateTime.Parse(Console.ReadLine());

        Console.Write("\nValue per hour: ");
        double ValuePerHour = double.Parse(Console.ReadLine());

        Console.Write("\nDuration (hours): ");
        int Hours = int.Parse(Console.ReadLine());

        worker.AddContract(new HourContract(Date, ValuePerHour, Hours));
        }

        Console.Write("\n\nEnter month and year to calculate income (MM/YYYY): ");
        string monthAndYear = Console.ReadLine();

        int month = int.Parse(monthAndYear.Substring(0, 2));
        int year = int.Parse(monthAndYear.Substring(3));

        Console.WriteLine(worker);

        Console.Write("income for " + monthAndYear + ": " + worker.Income(year, month) + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    }
}