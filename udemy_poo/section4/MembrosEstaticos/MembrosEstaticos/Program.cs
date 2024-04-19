using System;
using System.Globalization;

namespace MembrosEstaticos
{
    internal class Program
    {
        static double pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /*  Métodos estáticos da mesma classe

            double circ = Circunferencia(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de PI: " + pi.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*   Métodos De Instancias

            CalculadoraDeInstancia calc = new CalculadoraDeInstancia();

            double circ = calc.Circunferencia(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = calc.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de PI: " + calc.pi.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*  Métodos Estáticos*/
            double circ = CalculadoraEstatica.Circunferencia(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = CalculadoraEstatica.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de PI: " + CalculadoraEstatica.pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Circunferencia(double raio)
        {
            return 2.0 * pi * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * pi * raio * raio * raio;
        }

    }
}