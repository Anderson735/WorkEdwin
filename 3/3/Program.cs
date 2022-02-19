using System;

namespace _3
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

            if (salary == 0)
            {
                employee.salary = 1000;
                Console.WriteLine(employee.ShowDates());
            }
            else
            {
                employee.salary = salary;
                Console.WriteLine(employee.ShowDates());
            }
        }
    }

    class Employee
    {
        public string name { get; set; }
        public double salary { get; set; }

        public Employee(string Name, double Salary)
        {
            name = Name;
            salary = Salary;
        }

        public string ShowDates() => name + " su salario es: " + salary;


    }
}
