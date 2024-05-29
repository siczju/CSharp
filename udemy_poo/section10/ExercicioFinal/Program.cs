using ExercicioFinal.Entities;
using System.Globalization;

namespace ExercicioFinal;
 class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());
        List<TaxPayer> list = new List<TaxPayer>();

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Tax payer #" + i + " data");

            Console.Write("Individual or company (i/c)? ");
            char choose = char.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string Name = Console.ReadLine();

            Console.Write("Anual income: ");
            double AnualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (choose == 'i')
            {
                Console.Write("Health Expensives: ");
                double HealthExpensive = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Individual(HealthExpensive, Name, AnualIncome));
            }
            if (choose == 'c')
            {
                Console.Write("Number of employees: ");
                int Employee = int.Parse(Console.ReadLine());
                list.Add(new Company(Employee, Name, AnualIncome));
            }
        }
            Console.WriteLine("\nTAXES PAID: ");
            double TotalTaxes = 0;
            foreach(TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                TotalTaxes += taxPayer.Tax();
            }
                Console.WriteLine("\nTOTAL TAXES: $ " + TotalTaxes.ToString("F2", CultureInfo.InvariantCulture));

        
    }
}
