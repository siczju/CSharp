using System;
using System.Globalization;

namespace Class39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo(); // new é necessario qnd trabalha com classes, ele instancia as variaveis, a criação.
            Triangulo y = new Triangulo();
            // instanciação -> alocação dinâmica de memória 
            // Stack -> cria as variaveis estáticas
            // Heap -> quando o tipo da variavel é uma classe, pois ela é instanciada. ou seja o "new Triangulo();" cria um espaço na memoria heap pro objeto,
            // ai o x (que esta na memoria stack), vai apontar para esse objeto com todos os atributos da classe Triangulo na memória heap.
            // então o x é uma referência para o objeto, é um ponteiro.

            /*
             Triangulo x, y; -> declarando as variaveis do tipo Triangulo
             x = new Triangulo(); -> instanciando as variaveis

            objetos -> são instancias de uma classe
             */

            Console.WriteLine("Entre com as medidas do Triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           Console.WriteLine("Entre com as medidas do Triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            double areaX = x.Area();

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            double areaY = y.Area();

            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine(areaY > areaX ? "Maior área: Y" : "Maior área: X");

        }
    }
}