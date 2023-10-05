using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public abstract class Component
    {
        public string Name { get; }
        public Component(string name) 
        {
            Name = name;
        }

        public abstract decimal GetEmployeeSalary();
    }
}
