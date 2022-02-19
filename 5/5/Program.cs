using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre de la persona: ");
            string name = Console.ReadLine();

            Console.WriteLine("Ingrese la edad de la persona: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el salario de la persona: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            //Se genera un error ya que no se puede crear una instancia de una clase abstracta
            Person person = new Person();
            Employee employee = new Employee();
            employee.LoadData(name,age, salary);
            Console.WriteLine(employee.ShowData());
        }
    }

    abstract class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public void LoadData(string Name, int Age, double salary)
        {
            name = Name;
            age = Age;
        }

        public string ShowData()
        {
            return "Su nombre es " + name + " y su edad es " + age;
        }
    }

    class Employee : Person
    {
        public double salary { get; set; }

        public void LoadData(double Salary)
        {

            salary = Salary;

        }

        public new string ShowData()
        {
            return "Su nombre es " + name + " usted tiene " + age + " años y su salario es " + salary;
        }
    }
}
