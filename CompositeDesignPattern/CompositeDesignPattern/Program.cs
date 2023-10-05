using CompositeDesignPattern.Components;

namespace CompositeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Component emp1 = new EmployeeComponent("Jhon", 22000);
            Component emp2 = new EmployeeComponent("Rohan", 33000);
            Component emp3 = new EmployeeComponent("Priya", 42000);
            Component emp4 = new EmployeeComponent("Abhi", 52000);
            Component emp5 = new EmployeeComponent("Virat", 28000);


            CompositeComponent DotNetDepartment = new CompositeComponent("DotNetDepartment");
            CompositeComponent HRDepartment = new CompositeComponent("HRDepartment");
            CompositeComponent Root = new CompositeComponent("ABC-Company");

            // Add Two Department to our company
            Root.AddComponent(HRDepartment);
            Root.AddComponent(DotNetDepartment);

            // Add Employee to that Company department
            DotNetDepartment.AddComponent(emp3);
            DotNetDepartment.AddComponent(emp4);
            DotNetDepartment.AddComponent(emp5);
            HRDepartment.AddComponent(emp1);
            HRDepartment.AddComponent(emp2);



            Console.WriteLine("All Employees of the ABC Company");
            Console.WriteLine($"Total Salary of the Company: {Root.GetEmployeeSalary()}");

            //To display Salaries and Employees of the Dotnet Department
            Console.WriteLine("\nIT Department Employees");
            Console.WriteLine($"Total Salary of IT Department: {DotNetDepartment.GetEmployeeSalary()}");

            //To display Salaries and Employees of the HR Department
            Console.WriteLine("\nHR Department Employees");
            Console.WriteLine($"Total Salary of HR Department: {HRDepartment.GetEmployeeSalary()}");

            //To display Salaries and Employees of HR Department
            Console.WriteLine("\nSalary of Employee Pranaya:");
            emp1.GetEmployeeSalary();
            Console.WriteLine($"\nSalary of Employee Anurag: ");
            emp2.GetEmployeeSalary();

        }
    }
}