using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFinal.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenses { get; set; }

        public Individual(double healthExpenses, string Name, double AnnualIncome) : base (Name, AnnualIncome) { HealthExpenses = healthExpenses; }

        public override double Tax()
        {
            if (HealthExpenses > 0 && AnnualIncome < 20000) return (AnnualIncome * 0.15) - (HealthExpenses * 0.5);
            if (HealthExpenses > 0 && AnnualIncome > 20000) return (AnnualIncome * 0.25) - (HealthExpenses * 0.5);            
            if (AnnualIncome < 20000) return AnnualIncome * 0.15;
            return AnnualIncome * 0.25;
        }
    }
}
