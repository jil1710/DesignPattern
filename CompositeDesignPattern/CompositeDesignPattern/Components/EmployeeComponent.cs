using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Components
{
    public class EmployeeComponent : Component
    {
        public decimal Salary { get; }

        public EmployeeComponent(string name, decimal salary) : base(name)
        {
            Salary = salary;
        }

        public override decimal GetEmployeeSalary()
        {
            Console.WriteLine($"\tEmployee Name: {Name} and Salary: {Salary}");
            return Salary;
        }
    }
}
