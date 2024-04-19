using System;

namespace Class39
{
    internal class Triangulo
    {
        public double A; // nome de atributo começa com letra maiuscula
        public double B;
        public double C;

        // Criando um método para obtermos os beneficios de reaproveitamento e delegação

        // método para calcular a área
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
