using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Entities
{
    internal class OutSourceEmployee : Employee
    {
        public double AddtionalCharge { get; set; }
        public OutSourceEmployee() { }
        public OutSourceEmployee(string Name, int Hours, double ValuePerHour, double AddtionalCharge)
        : base(Name, Hours, ValuePerHour)
        {
            this.AddtionalCharge = AddtionalCharge;
        }
        public sealed override double Payment()
        {
            return base.Payment() + (AddtionalCharge * 1.1);
        }
    }
}
