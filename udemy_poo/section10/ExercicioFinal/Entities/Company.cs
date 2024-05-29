using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFinal.Entities
{
    internal class Company : TaxPayer
    {
        public int Employee { get; set; }
        public Company() { }
        public Company(int Employee, string Name, double AnnualIncome) : base(Name, AnnualIncome) { this.Employee = Employee; }

        public override double Tax()
        {
            if (Employee > 10) return AnnualIncome * 0.14;
            return AnnualIncome * 0.16;
        }
    }
}
