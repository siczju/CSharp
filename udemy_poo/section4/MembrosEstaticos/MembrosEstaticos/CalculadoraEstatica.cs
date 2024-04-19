using System;

namespace MembrosEstaticos
{
    static class CalculadoraEstatica
    {
        public static double pi = 3.14;
        public static double Circunferencia(double raio)
        {
            return 2.0 * pi * raio;
        }

        public static double Volume(double raio)
        {
            return 4.0 / 3.0 * pi * raio * raio * raio;
        }
    }
}
