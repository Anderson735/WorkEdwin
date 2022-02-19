using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor del lado del cuadrado: ");
            int side = Convert.ToInt32(Console.ReadLine());

            Square square = new Square();
            square.Side = side;
            Console.WriteLine(square.ShowPerimeter());
            Console.WriteLine(square.KnowSurface());
        }
    }

    class Square
    {
        public double Side { get; set; }

        public void LoadSide(double side)
        {
            Side = side;
        }

        public double ShowPerimeter() => Side * 4;

        public double KnowSurface() => Math.Pow(Side, 2);

    }
}
