using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el nombre de la persona: ");
            string name = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de horas que trabajo : ");
            int hours = Convert.ToInt32(Console.ReadLine());
           
            Empleado empleado = new Empleado();
            Manager manager = new Manager();
            empleado.hours = hours;
            manager.hours = hours;
            Console.WriteLine(empleado.calculateSalary());
            Console.WriteLine(manager.calculateSalary());

        }
    }

    abstract class Employee
    {
        public string name { get; set; }
        public int salary { get; set; }


        public abstract double calculateSalary();
        public string LoadData(string Name, double Salary)
        {
            return "Su nombre es " + Name + " y su salario es de " + Salary;
        }

        
    }

    class Empleado: Employee
    {
        public int hours { get; set; }
        public double cost { get; set; } = 3.50;

        public override double calculateSalary()
        {
            double salary = hours * cost;
            return salary;
        }
    }

    class Manager : Employee
    {
        public int hours { get; set; }
        public double cost { get; set; } = 3.50;
        public override double calculateSalary()
        {
            double salary = ((hours * cost)*0.10)+(hours * cost);
            return salary;
        }
    }
}
