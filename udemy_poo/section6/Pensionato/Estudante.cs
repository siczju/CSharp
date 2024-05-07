using System;

namespace Pensionato
{
    internal class Estudante
    {
        public int Quarto { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }

        public Estudante() { }
        public Estudante(string Nome, string Email, int Quarto)
        {
            this.Email = Email;
            this.Nome = Nome;
            this.Quarto = Quarto;
        }

        public override string ToString()
        {
            return Quarto + ": " + Nome + ", " + Email;
        }
    }
}
