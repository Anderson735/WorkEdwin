using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el monto: ");
            double monto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje para el impuesto: ");
            double porcentaje = Convert.ToDouble(Console.ReadLine());

            Venta venta = new Venta();
            Console.WriteLine(venta.ShowResult(monto, porcentaje));


        }
    }

    class Venta
    {
        public double ShowResult(double monto, double porcentaje)
        {
            double resultado = (monto * porcentaje) / 100;
            double total = monto + resultado;
            return total;
        }

        public double ShowImpuesto()
        {

        }

    }
}
