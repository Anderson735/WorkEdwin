using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del empleado: ");
            string name = Console.ReadLine();

            Console.WriteLine("Ingrese el salario del empleado: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Employee employee = new Employee(name, salary);
            Console.WriteLine(employee.KnowDebt());
        }
    }

    class Employee
    {
        private string name { get; set; }
        private double salary { get; set; }

        public Employee(string Name, double Salary)
        {
            name = Name;
            salary = Salary;
        }

        public string KnowDebt()
        {
            if (salary > 3000)
            {
                return "Señor/a " + name + " su salario es: " + salary + " por lo tanto debe pagar impuesto";
            }
            else
            {
                return "Señor/a " + name + " su salario es: " + salary + " por lo tanto no debe pagar impuesto";

            }
        }
    }
}
