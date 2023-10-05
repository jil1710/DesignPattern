using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Components
{
    public class CompositeComponent : Component
    {
        private List<Component> ChildComponents = new List<Component>();

        public CompositeComponent(string name) : base(name)
        {
            
        }

        public void AddComponent(Component NewComponent)
        {
            ChildComponents.Add(NewComponent);
        }

        public void RemoveComponent(Component RemoveComponent)
        {
            ChildComponents.Remove(RemoveComponent);
        }

        //Override the Component class GetSalary Method
        public override decimal GetEmployeeSalary()
        {
            return ChildComponents.Sum(x => x.GetEmployeeSalary());
        }

    }
}
