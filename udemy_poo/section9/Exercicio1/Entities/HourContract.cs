using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Entities
{
    internal class HourContract
    {
        public DateTime Date;
        public double ValuePerHour;
        public int Hours;
        public HourContract() { }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
