using System;

namespace MembrosEstaticos
{
    internal class CalculadoraDeInstancia
    {
        public double val;
        public double pi = 3.14;
        public double Circunferencia(double raio)
        {
            return 2.0 * pi * raio;
        }

        public double Volume(double raio)
        {
            return 4.0 / 3.0 * pi * raio * raio * raio;
        }
    }
}
