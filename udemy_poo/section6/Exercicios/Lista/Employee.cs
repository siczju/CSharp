using System;

namespace Lista
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int Id, string Name, double Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
        }

        public double IncreaseSalary(double percentage) => Salary += Salary * percentage / 100;

        public override string ToString()
        {
            return " " + Id + ", " + Name + ", " + Salary + ".";
        }
    }
}
