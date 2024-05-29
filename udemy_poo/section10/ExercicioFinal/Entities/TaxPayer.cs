using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFinal.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }
        public TaxPayer() { }
        public TaxPayer(string Name, double AnnualIncome) { this.Name = Name; this.AnnualIncome = AnnualIncome; }

        public abstract double Tax();
    }
}
